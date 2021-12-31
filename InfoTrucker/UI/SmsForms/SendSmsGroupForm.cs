﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using InfoTrucker.Infrastructure;
using InfoTrucker.Models;
using AutoMapper;
using InfoTrucker.DTO;
using System.Linq;
using InfoTrucker.Entities;
using static InfoTrucker.PublicValue;

namespace InfoTrucker.UI.SmsForms
{
    public partial class SendSmsGroupForm : XtraForm
    {
        private readonly UnitofWork<AppDbContext> _unitofWork;
        private readonly IMapper _mapper;
        private readonly ServiceReference1.tsmsServiceClient _soap;
        private List<PersonListForSmsDTO> _personListTemp;
        private List<PersonListForSmsDTO> _personListFoeSend;

        public SendSmsGroupForm(UnitofWork<AppDbContext> unitofWork, IMapper mapper)
        {
            InitializeComponent();
            _unitofWork = unitofWork;
            _mapper = mapper;
            _soap = new ServiceReference1.tsmsServiceClient();
            ConnectedToPanelSms();

        }

        /// <summary>
        /// ارتباط با سامانه پیام کوتاه و دریافت مشخصات سامانه
        /// </summary>
        private void ConnectedToPanelSms()
        {
            try
            {
                var soapConnect = _soap.UserInfo(SmsUsername, SmsPassword);
                if (soapConnect[0].sms_numebrs[0] == SmsNumber)// && soapConnect[0].sms_numebrs[0].Length == 10
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
                ExseptionMessage(ex.Message);
                Close();
            }
        }


        /// <summary>
        /// لیست پرسنل سامانه 
        /// </summary>
        private async void PersonListForSend()
        {
            var resultPerson = await _unitofWork.Person.GetAllAsync();
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

        private void SendButton_Click(object sender, EventArgs e)
        {

            Clacuter();
            try
            {
                //string senderNumber = string.Join(",", _personListFoeSend.Select(x => x.Mobile1).ToArray());
                var reciverNumber = string.Join(",", _personListFoeSend.Select(x => x.Mobile1).ToArray());
                var message = MessageTextbox.Text.Trim();
                var wsdlCheckSendStr = RandomString(10);
                var resultSend = _soap.sendSmsGroup(SmsUsername, SmsPassword, SmsNumber, reciverNumber, message, 0, wsdlCheckSendStr);
                if (resultSend[0] > 0) SuccsessSendSMS(resultSend[0].ToString());
                //var resultWsdlCheckSend = soap.WsdlCheckSend(PublicValue.SmsUsername, PublicValue.SmsPassword, WsdlCheckSendStr);

                try
                {
                    foreach (var item in _personListFoeSend)
                    {


                        var recorder = new SendMessages();
                        recorder.Message = message;
                        recorder.RegisterTime = DateTime.Now;
                        recorder.WsdlCheckSend = 0;
                        recorder.WsdlCheckSendString = wsdlCheckSendStr;
                        recorder.Reciver = item.Mobile1;
                        recorder.ResultNumber = resultSend[0];
                        recorder.SendGroup = true;

                        _unitofWork.SMS.Insert(recorder);
                        _unitofWork.Commit();
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    ErrorSaveMessage();
                    ExseptionMessage(ex.Message);
                }


            }
            catch (Exception ex)
            {
                ExseptionMessage(ex.Message);
                //var exMessage = ex.Message;
            }

        }

        private void CheckStatusButton_Click(object sender, EventArgs e)
        {

        }
    }
}