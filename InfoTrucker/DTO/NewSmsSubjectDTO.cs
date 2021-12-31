using System;

namespace InfoTrucker.DTO
{
    public class NewSmsSubjectDTO
    {
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool SendGroup { get; set; }
        public DateTime CreateTime { get; set; }
        public string WsdlString { get; set; }
        public int WsdlCheckSend { get; set; }
    }
}
