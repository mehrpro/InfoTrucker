using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using DevExpress.XtraEditors;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;

namespace InfoTrucker.UI.SmsForms
{
    public partial class SendStatusForm : XtraForm
    {
        private readonly UnitofWork<AppDbContext> _unitofWork;
        private readonly IMapper _mapper;
        private readonly ServiceReference1.tsmsServiceClient soap;


        public SendStatusForm(UnitofWork<AppDbContext> unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
            soap = new ServiceReference1.tsmsServiceClient();
            InitializeComponent();
            ConnectedToPanel();
        }

        private void PersonListComboBox()
        {
            var resultPerson = _unitofWork.Person.GetAll();
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
                    //CreditTextbox.Text = soapConnect[0].credit.ToString();
                    //PersonListCombobox();
                }
                else
                {
                    throw new Exception("اشکال در ارتباط با سامانه با مدیر سیستم تماس بگیرید");
                }
            }

            catch (Exception ex)
            {
                PublicValue.ExseptionMessage(ex.Message);
                //SendButton.Enabled = false;
            }

        }



    }
}
