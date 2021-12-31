using System;
using System.Collections.Generic;

namespace InfoTrucker.Entities
{
    public class MessageGroupSubject
    {

        public MessageGroupSubject()
        {
            SendMessageses = new HashSet<SendMessages>();
        }


        public int ID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool SendGroup { get; set; }
        public DateTime CreateTime { get; set; }
        public string WsdlString { get; set; }
        public int WsdlCheckSend { get; set; }



        public virtual ICollection<SendMessages> SendMessageses { get; set; }



    }
}
