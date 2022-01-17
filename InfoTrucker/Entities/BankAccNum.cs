using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.Entities
{

    public class BankAccNum
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string BankName { get; set; }
        public string AccNumber { get; set; }
        public string AccCart { get; set; }
        public string AccISBN { get; set; }
        public string Editor { get; set; }
        public int CenterID_FK { get; set; }
        public Center Center { get; set; }
    }
}
