using System;
using System.Collections.Generic;

namespace InfoTrucker.Entities
{
    public class Commission
    {
        public Commission()
        {
            this.Queues = new HashSet<Queue>();
        }

        public short CommissionID { get; set; }

        public int CommissionPrice { get; set; }
        public DateTime DataRegister { get; set; }
        public bool enabled { get; set; }

        public byte Groups_FK { get; set; }
        public virtual LoadType LoadType { get; set; }

        public byte GroupID { get; set; }
        public virtual LoadType LoadType1 { get; set; }

        public int CenterID_FK { get; set; }
        public virtual Center Center { get; set; }



        public virtual ICollection<Queue> Queues { get; }
    }
}
