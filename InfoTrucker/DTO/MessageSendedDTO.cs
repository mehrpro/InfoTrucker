using System;

namespace InfoTrucker.DTO
{
    public class MessageSendedDTO
    {
        public int Row { get; set; }
        public string Message { get; set; }
        public int ResultCode { get; set; }
        public DateTime DateSending { get; set; }
    }
}