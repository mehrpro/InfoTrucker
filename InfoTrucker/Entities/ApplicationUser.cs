using System.Collections.Generic;

namespace InfoTrucker.Entities
{
    /// <summary>
    /// کاربران
    /// </summary>
    public class ApplicationUser
    {
        public ApplicationUser()
        {
            Cleams = new HashSet<Cleam>();
            Persons = new HashSet<Person>();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FullName { get; set; }

        public string Editor { get; set; }
        public bool LimetedCompany { get; set; }

        public bool Enabled { get; set; }

        public virtual ICollection<Cleam> Cleams { get; set; }
        public virtual ICollection<Person> Persons { get; set; }



    }
}