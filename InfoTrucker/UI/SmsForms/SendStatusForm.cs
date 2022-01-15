using System;
using System.Collections.Generic;
using System.Drawing;
using AutoMapper;
using DevExpress.XtraEditors;
using InfoTrucker.DTO;
using InfoTrucker.Infrastructure;
using InfoTrucker.Services;

namespace InfoTrucker.UI.SmsForms
{
    public partial class SendStatusForm : XtraForm
    {
        private readonly IUnitofWork _unitofWork;
        private readonly ISendMessageRepository _messageRepository;
        private readonly IMessageGroupSubjectRepository _messageGroupSubjectRepository;
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private readonly IUnitOfWorkClass _unitOfWorkClass;


        public SendStatusForm(IUnitofWork unitofWork,
                              ISendMessageRepository messageRepository,
                              IMessageGroupSubjectRepository messageGroupSubjectRepository,
                              IMapper mapper,
                              IPersonRepository personRepository,
                              IUnitOfWorkClass unitOfWorkClass)
        {
            _unitofWork = unitofWork;
            _messageRepository = messageRepository;
            _messageGroupSubjectRepository = messageGroupSubjectRepository;
            _mapper = mapper;
            _personRepository = personRepository;
            _unitOfWorkClass = unitOfWorkClass;
            InitializeComponent();
            cbxPersonList.Properties.DisplayMember = "FullName";
            cbxPersonList.Properties.ValueMember = "ID";
            ConnectedToPanel();
            PersonListComboBox();
        }

        private void PersonListComboBox()
        {
            var resultPerson = _personRepository.GetAllEnumerable();
            var resultMap = _mapper.Map<IEnumerable<PersonListForSms>>(resultPerson);
            cbxPersonList.Properties.DataSource = resultMap;
        }

        private void ConnectedToPanel()
        {
            try
            {
                var soapConnect = _unitOfWorkClass.SMSClient.UserInfo(PublicValue.SmsUsername, PublicValue.SmsPassword);
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

        private async void cbxPersonList_EditValueChanged(object sender, EventArgs e)
        {
            var _selected = (PersonListForSms)cbxPersonList.GetSelectedDataRow();
            if (_selected == null)
            {
                return;
            }

            var resultSended = await _messageRepository.GetMessagesByPersonIdAsync(_selected.ID);
            var list = new List<MessageSendedDTO>();
            int row = 0;
            foreach (var item in resultSended)
            {
                list.Add(new MessageSendedDTO
                {
                    Row = ++row,
                    Message = item.MessageGroupSubject.Message,
                    ResultCode = item.ResultSend,
                    DateSending = item.MessageGroupSubject.CreateTime
                });
            }
            SendingGridControl.DataSource = list;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
