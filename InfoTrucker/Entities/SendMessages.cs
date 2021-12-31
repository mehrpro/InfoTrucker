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
        public string Title { get; set; }
        public DateTime RegisterTime { get; set; }
        public string Message { get; set; }
        public string Reciver { get; set; }
        public int ResultNumber { get; set; }
        public int ReciverNumber { get; set; }
        public string WsdlCheckSendString { get; set; }
        public int WsdlCheckSend { get; set; }
        public bool SendGroup { get; set; }
        public bool  CheckedStatusFromWenService { get; set; }


    }
}
