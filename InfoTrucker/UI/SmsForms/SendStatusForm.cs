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
using InfoTrucker.DTO;
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
            cbxPersonList.Properties.DisplayMember = "FullName";
            cbxPersonList.Properties.ValueMember = "ID";
            ConnectedToPanel();
        }

        private void PersonListComboBox()
        {
            var resultPerson = _unitofWork.Person.GetAll();
            var resultMap = _mapper.Map<IEnumerable<PersonListForSms>>(resultPerson);
            cbxPersonList.Properties.DataSource = resultMap;

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
                    PersonListComboBox();
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

        private void cbxPersonList_EditValueChanged(object sender, EventArgs e)
        {
            var _selectPerson = (PersonListForSms)cbxPersonList.GetSelectedDataRow();
            var sendMessageses = _unitofWork.SMS.GetMany(x => x.PersonID_FK == _selectPerson.ID);
            var rest = _unitofWork.contextdb.MessageGroupSubjects.Include()
            //var resultInt = array.Select(x => x.ResultSend).ToArray();

            //foreach (var i in resultInt)
            //{
            //    var result = soap.GetDeliverySms(PublicValue.SmsUsername, PublicValue.SmsPassword, new int[] { i });
            //}

            var list = new List<SendStatusDTO>();
            int row = 0;
            foreach (var item in sendMessageses)
            {
                var dto = new SendStatusDTO();
                dto.ID = ++row;
                dto.Message = item.MessageGroupSubject.Message.Trim();
                dto.Result = item.ResultSend;
                dto.TimeSend = item.MessageGroupSubject.CreateTime;
                list.Add(dto);
            }


            SendGridControl.DataSource = list;


        }
    }
}
