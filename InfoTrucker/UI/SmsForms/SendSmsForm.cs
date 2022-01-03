using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using InfoTrucker.DTO;
using InfoTrucker.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using AutoMapper;
using InfoTrucker.Infrastructure;
using InfoTrucker.Services;

namespace InfoTrucker.UI.SmsForms
{
    public partial class SendSmsForm : XtraForm
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private readonly IMessageGroupSubjectRepository _messageGroupSubjectRepository;

        private readonly IExceptionSms _exceptionSms;
        private readonly ISendMessageRepository _messageRepository;
        private readonly ServiceReference1.tsmsServiceClient soap;
        public SendSmsForm(IUnitofWork unitofWork, IMapper mapper, IPersonRepository personRepository
        , IMessageGroupSubjectRepository messageGroupSubjectRepository, IExceptionSms exceptionSms, ISendMessageRepository messageRepository)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
            _personRepository = personRepository;
            _messageGroupSubjectRepository = messageGroupSubjectRepository;

            _exceptionSms = exceptionSms;
            _messageRepository = messageRepository;
            soap = new ServiceReference1.tsmsServiceClient();
            InitializeComponent();
            PersonListSearchLookUp.Properties.DisplayMember = "Mobile1";
            PersonListSearchLookUp.Properties.ValueMember = "ID";


            ConnectedToPanel();


        }


        private void PersonListCombobox()
        {
            var result = _personRepository.GetAllEnumerable();
            var resultList = _mapper.Map<IEnumerable<PersonListForSms>>(result);
            PersonListSearchLookUp.Properties.DataSource = resultList;

        }

        private bool CalcuterPrice()
        {
            var credit = Convert.ToInt32(CreditTextbox.EditValue);
            var pageSms = Convert.ToInt32(MessageTextbox.Text.Length) / 64 + 1;
            var result = pageSms * PublicValue.SmsPrice;
            return result < credit ? true : false;
        }

        private void ConnectedToPanel()
        {
            try
            {


                var soapConnect = soap.UserInfo(PublicValue.SmsUsername, PublicValue.SmsPassword);

                if (soapConnect[0].sms_numebrs[0] == PublicValue.SmsNumber)
                {
                    SmsNumberTextbox.Text = soapConnect[0].sms_numebrs[0];
                    SmsNumberTextbox.ReadOnly = true;
                    SmsNumberTextbox.BackColor = Color.LightGreen;
                    CreditTextbox.Text = soapConnect[0].credit.ToString();
                    PersonListCombobox();
                }
                else
                {
                    throw new Exception("اشکال در ارتباط با سامانه با مدیر سیستم تماس بگیرید");
                }
            }

            catch (Exception ex)
            {
                PublicValue.ExseptionMessage(ex.Message);
                SendButton.Enabled = false;
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            if (!CalcuterPrice()) return;
            SplashScreenManager.ShowForm(this, typeof(WaitSaveSMSForm), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("در حال ارسال پیامک ...");
            var wsdlCheckSendStr = PublicValue.RandomString(10);
            try
            {
                var objectWsdl = new NewSmsSubjectDTO
                {
                    CreateTime = DateTime.Now,
                    Subject = $"ارسال پیام به {PersonListSearchLookUp.Text}",
                    WsdlString = wsdlCheckSendStr,
                    SendGroup = false,
                    Message = MessageTextbox.Text.Trim(),

                };
                var resultMap = _mapper.Map<MessageGroupSubject>(objectWsdl);
                _messageGroupSubjectRepository.Insert(resultMap);
                _unitofWork.SaveChanges();
                string[] SmsSender = { PublicValue.SmsNumber };
                var resultTitleNumber = Convert.ToInt32(resultMap.ID);
                string[] receiverNumber = { PersonListSearchLookUp.Text.ToString() };
                string[] message = { MessageTextbox.Text.Trim() };
                string[] msc = new string[] { };
                var resultSend = await soap.sendSmsAsync(PublicValue.SmsUsername, PublicValue.SmsPassword,
                  SmsSender, receiverNumber, message, msc, wsdlCheckSendStr);
                if (Convert.ToInt32(resultSend[0]) < 0) throw new IndexOutOfRangeException(resultSend[0].ToString());
                SplashScreenManager.Default.SetWaitFormDescription($"شماره پیگیری {resultSend[0]}");
                Thread.Sleep(1025);
                SplashScreenManager.Default.SetWaitFormDescription("در حال ثبت اطلاعات");
                try
                {
                    var recorder = new NewSendMessageDTO
                    {
                        PersonID_FK = Convert.ToInt32(PersonListSearchLookUp.EditValue),
                        ResultSend = resultSend[0],
                        CheckedStatusFromWenService = false,
                        MessageSubjectID_FK = resultTitleNumber

                    };
                    var resultMapMessage = _mapper.Map<SendMessages>(recorder);
                    _messageRepository.Insert(resultMapMessage);
                    _unitofWork.SaveChanges();
                    SplashScreenManager.CloseForm(false);
                    Close();
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
    }
}
