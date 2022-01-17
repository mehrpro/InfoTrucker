using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.Entities
{
    public class Center
    {
        public Center()
        {
            Cashes = new HashSet<Cash>();
            Commissions = new HashSet<Commission>();
            Drivers = new HashSet<Driver>();
            PhoneBooks = new HashSet<PhoneBook>();
            Queues = new HashSet<Queue>();
            SeriesPrices = new HashSet<SeriesPrice>();
            Users = new HashSet<User>();
            BankAccNums = new HashSet<BankAccNum>();
        }


        public int ID { get; set; }
        public string CenterTitle { get; set; }
        public string TokenKey { get; set; }
        public string Description { get; set; }


        public virtual ICollection<Cash> Cashes { get; set; }
        public virtual ICollection<Commission> Commissions { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<PhoneBook> PhoneBooks { get; set; }
        public virtual ICollection<Queue> Queues { get; set; }
        public virtual ICollection<SeriesPrice> SeriesPrices { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<BankAccNum> BankAccNums { get; set; }

    }
}
