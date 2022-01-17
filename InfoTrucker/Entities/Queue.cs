using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoTrucker.Entities
{
    public class Queue
    {
        public Queue()
        {
            this.Cashes = new HashSet<Cash>();
        }

        public int ID { get; set; }
        public short Number { get; set; }

        public byte GroupCommission { get; set; }


        public short ComosiunID_FK { get; set; }
        public virtual Commission Commission { get; set; }


        public byte Type_FK { get; set; }
        public virtual LoadType LoadType { get; set; }


        public DateTime DateTimeRegister { get; set; }
        public int DriverID_FK { get; set; }
        public virtual Driver Driver { get; set; }

        public byte Status_FK { get; set; }
        public virtual LoadType LoadType1 { get; set; }



        public int SeriesID_FK { get; set; }
        public virtual SeriesPrice SeriesPrice { get; set; }

        public bool? mandeh { get; set; }

        public int CenterID_FK { get; set; }
        public Center Center { get; set; }

        public virtual ICollection<Cash> Cashes { get; set; }





    }

}
