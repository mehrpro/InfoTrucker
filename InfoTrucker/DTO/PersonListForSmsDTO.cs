using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.DTO
{
    public class PersonListForSmsDTO
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Mobile1 { get; set; }
        public bool SendSMS { get; set; }
    }
}
