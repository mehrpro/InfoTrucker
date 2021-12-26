using DevExpress.XtraEditors;
using InfoTrucker.DTO;
using InfoTrucker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if (soapConnect[0].sms_numebrs[0] == PublicValue.SmsNumber)// && soapConnect[0].sms_numebrs[0].Length == 10
                {
                    SmsNumberTextbox.Text = soapConnect[0].sms_numebrs[0];
                    SmsNumberTextbox.ReadOnly = true;
                    SmsNumberTextbox.BackColor = Color.LightGreen;
                    CreditTextbox.Text = soapConnect[0].credit.ToString();
                    PersonListCombobox();
                }
            }
            catch (Exception ex)
            {
                PublicValue.ExseptionMessage(ex.Message);
                Close();
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] senderNumber = { PublicValue.SmsNumber };
                string[] reciverNumber = { PersonListSearchLookUp.EditValue.ToString() };
                string[] message = { MessageTextbox.Text.Trim() };
                string WsdlCheckSendStr = PublicValue.RandomString(10);
                var resultSend = soap.sendSms(PublicValue.SmsUsername, PublicValue.SmsPassword, senderNumber, reciverNumber, message, new string[] { }, WsdlCheckSendStr);
                if (resultSend[0] > 0)
                {
                    PublicValue.SuccsessSendSMS(resultSend[0].ToString());

                }
                var resultWsdlCheckSend = soap.WsdlCheckSend(PublicValue.SmsUsername, PublicValue.SmsPassword, WsdlCheckSendStr);

                try
                {
                    var recorder = new SendMessages();
                    recorder.Message = message[0].ToString();
                    recorder.RegisterTime = DateTime.Now;
                    recorder.WsdlCheckSend = resultWsdlCheckSend[0];
                    recorder.WsdlCheckSendString = WsdlCheckSendStr.ToString();
                    recorder.Reciver = reciverNumber[0].ToString();
                    recorder.ResultNumber = resultSend[0];
                    _unitofWork.SMS.Insert(recorder);
                    _unitofWork.Commit();
                    Close();
                }
                catch(Exception ex)
                {
                    var ed = ex.Message;
                    PublicValue.ErrorSaveMessage();
                }


            }
            catch (Exception ex)
            {

                var exMessage = ex.Message;
            }
        }
    }
}
