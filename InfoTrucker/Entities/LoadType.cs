using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.Entities
{
    public partial class LoadType
    {
        public LoadType()
        {
            this.Commissions = new HashSet<Commission>();
            this.Commissions1 = new HashSet<Commission>();
            this.Drivers = new HashSet<Driver>();
            this.Queues = new HashSet<Queue>();
            this.Queues1 = new HashSet<Queue>();
        }

        public byte TypeID { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Commission> Commissions { get; set; }
        public virtual ICollection<Commission> Commissions1 { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<Queue> Queues { get; set; }
        public virtual ICollection<Queue> Queues1 { get; set; }
    }
}
