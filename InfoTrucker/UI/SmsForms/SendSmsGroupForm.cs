using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;
using AutoMapper;
using InfoTrucker.DTO;
using System.Linq;
using System.Threading;
using DevExpress.XtraSplashScreen;
using InfoTrucker.Entities;
using InfoTrucker.Services;


namespace InfoTrucker.UI.SmsForms
{
    public partial class SendSmsGroupForm : XtraForm
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private readonly ISendMessageRepository _messageRepository;
        private readonly IMessageGroupSubjectRepository _messageGroupSubjectRepository;
        private readonly IExceptionSms _exceptionSms;
        private readonly IUnitOfWorkClass _unitOfWorkClass;
        private List<PersonListForSmsDTO> _personListTemp;
        private List<PersonListForSmsDTO> _personListFoeSend;

        public SendSmsGroupForm(IUnitofWork unitofWork,
                                IMapper mapper,
                                IPersonRepository personRepository,
                                ISendMessageRepository messageRepository,
                                IMessageGroupSubjectRepository messageGroupSubjectRepository,
                                IExceptionSms exceptionSms,
                                IUnitOfWorkClass unitOfWorkClass)
        {
            InitializeComponent();
            _unitofWork = unitofWork;
            _mapper = mapper;
            _personRepository = personRepository;
            _messageRepository = messageRepository;
            _messageGroupSubjectRepository = messageGroupSubjectRepository;
            _exceptionSms = exceptionSms;
            _unitOfWorkClass = unitOfWorkClass;
            ConnectedToPanelSms();

        }

        /// <summary>
        /// ارتباط با سامانه پیام کوتاه و دریافت مشخصات سامانه
        /// </summary>
        private void ConnectedToPanelSms()
        {
            try
            {
                var soapConnect = _unitOfWorkClass.SMSClient.UserInfo(PublicValue.SmsUsername, PublicValue.SmsPassword);
                if (soapConnect[0].sms_numebrs[0] == PublicValue.SmsNumber)// && soapConnect[0].sms_numebrs[0].Length == 10
                {
                    SmsNumberTextbox.Text = soapConnect[0].sms_numebrs[0];
                    SmsNumberTextbox.ReadOnly = true;
                    SmsNumberTextbox.BackColor = Color.LightGreen;
                    CreditTextbox.Text = soapConnect[0].credit.ToString();
                    PersonListForSend();
                }
            }
            catch (Exception ex)
            {
                PublicValue.ExseptionMessage(ex.Message);
                Close();
            }
        }


        /// <summary>
        /// لیست پرسنل سامانه 
        /// </summary>
        private void PersonListForSend()
        {
            var resultPerson = _personRepository.GetAllEnumerable();
            var result = _mapper.Map<IEnumerable<PersonListForSmsDTO>>(resultPerson);
            foreach (var item in result)
            {
                item.SendSMS = true;
            }
            PersonGridControl.DataSource = result;
            Clacuter();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessageTextbox_EditValueChanged(object sender, EventArgs e)
        {
            Clacuter();
            SMSPageTextbox.Text = (Convert.ToInt32(MessageTextbox.Text.Length) / 64 + 1).ToString();
        }

        /// <summary>
        /// محاسبه تعداد پرسنل انتخاب شده برای ارسال 
        /// </summary>
        private void Clacuter()
        {
            _personListTemp = PersonGridControl.DataSource as List<PersonListForSmsDTO>;
            ReciverNumberTextbox.Text = _personListTemp.Count(x => x.SendSMS).ToString();
            _personListFoeSend = _personListTemp.Where(x => x.SendSMS).ToList();
            CalcuterTextbx.Text = (Convert.ToInt32(ReciverNumberTextbox.EditValue) * Convert.ToInt32(SMSPageTextbox.EditValue) * 283).ToString();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Clacuter();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CalcuterTextbx.Text) > Convert.ToInt32(CreditTextbox.Text))
            {
                PublicValue.ExseptionMessage("اعتبار کافی برای ارسال ندارید");
                return;
            }
            SplashScreenManager.ShowForm(this, typeof(WaitSaveSMSForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("در حال ارسال پیامک  ......");
            Clacuter();
            var wsdlCheckSendStr = PublicValue.RandomString(10);
            try
            {
                var objectWsdl = new NewSmsSubjectDTO
                {
                    CreateTime = DateTime.Now,
                    Subject = string.IsNullOrWhiteSpace(TitleTextbox.Text) ? $"ارسال گروهی در تاریخ {DateTime.Now}" : TitleTextbox.Text.Trim(),
                    WsdlString = wsdlCheckSendStr,
                    SendGroup = true,
                    Message = MessageTextbox.Text.Trim(),
                };
                var resultMap = _mapper.Map<MessageGroupSubject>(objectWsdl);
                _messageGroupSubjectRepository.Insert(resultMap);
                _unitofWork.SaveChanges();
                var resultTitleNumber = Convert.ToInt32(resultMap.ID);
                var receiverNumber = string.Join(",", _personListFoeSend.Select(x => x.Mobile1).ToArray());
                var message = MessageTextbox.Text.Trim();
                var resultSend = await _unitOfWorkClass.SMSClient.sendSmsGroupAsync(PublicValue.SmsUsername, PublicValue.SmsPassword,
                    PublicValue.SmsNumber, receiverNumber, message, 0, wsdlCheckSendStr);
                if (Convert.ToInt32(resultSend[0]) < 0) throw new IndexOutOfRangeException(resultSend[0].ToString());
                SplashScreenManager.Default.SetWaitFormDescription($"شماره پیگیری {resultSend[0]}");
                Thread.Sleep(1025);
                SplashScreenManager.Default.SetWaitFormDescription("در حال ثبت اطلاعات");
                try
                {
                    foreach (var item in _personListFoeSend)
                    {
                        var recorder = new NewSendMessageDTO
                        {
                            PersonID_FK = item.ID,
                            ResultSend = resultSend[0],
                            CheckedStatusFromWenService = false,
                            MessageSubjectID_FK = resultTitleNumber,
                        };
                        var resultMapMessage = _mapper.Map<SendMessages>(recorder);
                        _messageRepository.Insert(resultMapMessage);
                        _unitofWork.SaveChanges();
                        SplashScreenManager.CloseForm(false);

                        Close();
                    }
                }
                catch (Exception ex)
                {
                    PublicValue.ExseptionMessage(ex.Message);
                }
            }
            catch (IndexOutOfRangeException exception)
            {

                var message = _exceptionSms.ExceptionMessage(exception.Message);
                PublicValue.ExseptionMessage(message);
            }
            catch (Exception ex)
            {
                PublicValue.ExseptionMessage(ex.Message);
            }
            SplashScreenManager.CloseForm(false);
        }

        private void CheckStatusButton_Click(object sender, EventArgs e)
        {

        }
    }
}
