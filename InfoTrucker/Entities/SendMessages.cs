using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.Entities
{
    public class SendMessages
    {
        public long ID { get; set; }
        public DateTime RegisterTime { get; set; }
        public string Message { get; set; }
        public string Reciver { get; set; }
        public int ResultNumber { get; set; }
        public string WsdlCheckSendString { get; set; }
        public int WsdlCheckSend { get; set; }


    }
}
