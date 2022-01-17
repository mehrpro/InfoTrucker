using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.Entities
{
    public class Cash
    {
        public int CashID { get; set; }
        public int? QueueID_FK { get; set; }
        public int? Pos { get; set; }
        public int? CashDesk { get; set; }
        public byte? userID { get; set; }
        public int? seriesID_FK { get; set; }
        public int CenterID_FK { get; set; }
        public Center Center { get; set; }

        public virtual Queue Queue { get; set; }
        public virtual SeriesPrice SeriesPrice { get; set; }
        public virtual User User { get; set; }
    }
}
