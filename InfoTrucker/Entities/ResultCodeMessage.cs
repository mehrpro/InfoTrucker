using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.Entities
{
    public class ResultCodeMessage
    {
        public ResultCodeMessage()
        {
            SendMessages = new HashSet<SendMessages>();
        }

        public int ID { get; set; }
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }

        public virtual ICollection<SendMessages> SendMessages { get; set; }

    }
}
