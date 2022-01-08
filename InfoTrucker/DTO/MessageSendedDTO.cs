using System;
using System.ComponentModel.DataAnnotations;

namespace InfoTrucker.DTO
{
    public class MessageSendedDTO
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }
        [Display(Name = "پیام")]
        public string Message { get; set; }
        [Display(Name = "شناسه")]
        public int ResultCode { get; set; }
        [Display(Name = "تاریخ ارسال")]
        public DateTime DateSending { get; set; }
    }
}