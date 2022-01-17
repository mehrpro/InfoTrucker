using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.Entities
{
    public class SeriesPrice
    {
        public SeriesPrice()
        {
            this.Cashes = new HashSet<Cash>();
            this.Queues = new HashSet<Queue>();
        }

        public int SereisID { get; set; }
        public int SeriesName { get; set; }
        public int? SeriesCount { get; set; }
        public DateTime SeriesDateStart { get; set; }
        public DateTime? SeriesDateEnd { get; set; }
        public int? Faleh { get; set; }
        public int? Packet { get; set; }
        public int? Gandom { get; set; }
        public int? Clinker { get; set; }
        public bool? closing { get; set; }

        public short? Member { get; set; }
        public short? Native { get; set; }
        public short? Other { get; set; }
        public bool? enabeled { get; set; }

        public byte? userCreator { get; set; }
        public virtual User User { get; set; }

        public int CenterID_FK { get; set; }
        public Center Center { get; set; }

        public virtual ICollection<Cash> Cashes { get; set; }
        public virtual ICollection<Queue> Queues { get; set; }

    }

}
