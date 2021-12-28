using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;
using AutoMapper;
using InfoTrucker.DTO;

namespace InfoTrucker.UI.SmsForms
{
    public partial class SendSmsGroupForm : XtraForm
    {
        private readonly UnitofWork<AppDbContext> _unitofWork;
        private readonly IMapper _mapper;
        private readonly ServiceReference1.tsmsServiceClient soap;

        public SendSmsGroupForm(UnitofWork<AppDbContext> unitofWork, IMapper mapper)
        {
            InitializeComponent();
            _unitofWork = unitofWork;
            _mapper = mapper;
            soap = new ServiceReference1.tsmsServiceClient();

            ConnectedToPanelSMS();

        }

        private void ConnectedToPanelSMS()
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
                    PersonListForSend();
                }
            }
            catch (Exception ex)
            {
                PublicValue.ExseptionMessage(ex.Message);
                Close();
            }
        }

        private async void PersonListForSend()
        {
            var resultPerson = await _unitofWork.Person.GetAllAsync();
            var result = _mapper.Map<IEnumerable<PersonListForSmsDTO>>(resultPerson);
            foreach (var item in result)
            {
                item.SendSMS = true;
            }
            PersonGridControl.DataSource = result;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MessageTextbox_EditValueChanged(object sender, EventArgs e)
        {
            CharNumberLabel.Text = (Convert.ToInt32(MessageTextbox.Text.Length) / 64 + 1).ToString();
        }
    }
}
