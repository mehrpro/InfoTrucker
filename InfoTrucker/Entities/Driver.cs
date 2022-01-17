using System.Collections.Generic;

namespace InfoTrucker.Entities
{
    public class Driver
    {
        public Driver()
        {
            this.Queues = new HashSet<Queue>();
        }

        public int DriverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int SmartCart { get; set; }
        public string TagNumber { get; set; }
        public string Tag { get; set; }


        public byte? editor_FK { get; set; }
        public int? driver_code { get; set; }

        public byte GroupID { get; set; }
        public virtual LoadType LoadType { get; set; }

        public byte userID_FK { get; set; }
        public virtual User User { get; set; }

        public int CenterID_FK { get; set; }
        public virtual Center Center { get; set; }


        public virtual ICollection<Queue> Queues { get; set; }
    }

}
