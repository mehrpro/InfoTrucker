using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using InfoTrucker.DTO;
using InfoTrucker.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace InfoTrucker.UI.SmsForms
{
    public partial class SendSmsForm : XtraForm
    {
        private readonly Infrastructure.UnitofWork<Models.AppDbContext> _unitofWork;
        private readonly AutoMapper.IMapper _mapper;
        private readonly ServiceReference1.tsmsServiceClient soap;
        public SendSmsForm(Infrastructure.UnitofWork<Models.AppDbContext> unitofWork, AutoMapper.IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
            soap = new ServiceReference1.tsmsServiceClient();
            InitializeComponent();
            PersonListSearchLookUp.Properties.DisplayMember = "FullName";
            PersonListSearchLookUp.Properties.ValueMember = "Mobile1";
            ConnectedToPanel();

        }


        private void PersonListCombobox()
        {
            var result = _unitofWork.Person.GetAll();
            var resultList = _mapper.Map<IEnumerable<PersonListForSms>>(result);
            PersonListSearchLookUp.Properties.DataSource = resultList;

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
                _unitofWork.SmsSubject.Insert(resultMap);
                _unitofWork.Commit();
                var resultTitleNumber = Convert.ToInt32(resultMap.ID);
                string receiverNumber = PersonListSearchLookUp.EditValue.ToString();
                var message = MessageTextbox.Text.Trim();
                var resultSend = await soap.sendSmsGroupAsync(PublicValue.SmsUsername, PublicValue.SmsPassword,
                    PublicValue.SmsNumber, receiverNumber, message, 0, wsdlCheckSendStr);
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
                    _unitofWork.SMS.Insert(resultMapMessage);
                    _unitofWork.Commit();
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
                var message = _unitofWork.ExceptionSms.ExceptionMessage(exception.Message);
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
