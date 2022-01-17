using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.Entities
{
    public class User
    {
        public User()
        {
            this.Cashes = new HashSet<Cash>();
            this.Drivers = new HashSet<Driver>();
            this.SeriesPrices = new HashSet<SeriesPrice>();
        }

        public byte userID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Roul { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public int CenterID_FK { get; set; }
        public Center Center { get; set; }

        public virtual ICollection<Cash> Cashes { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<SeriesPrice> SeriesPrices { get; set; }
    }

}
