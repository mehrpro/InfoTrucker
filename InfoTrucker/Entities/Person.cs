using System;
using System.Collections.Generic;

namespace InfoTrucker.Entities
{
    public class Person
    {

        public Person()
        {
            SendMessages = new HashSet<SendMessages>();
        }


        public int ID { get; set; }
        public int PersonID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string FatherName { get; set; }
        public DateTime Tavalod { get; set; }
        public string CodeMelei { get; set; }
        public byte Takalof { get; set; }
        public string SerialShenasnameh { get; set; }
        public string Shenasnameh { get; set; }
        public string MahelTavalod { get; set; }
        public string Hoshmand { get; set; }
        public string Sh_Bimeh { get; set; }
        public string Sh_Goyahinameh { get; set; }
        public string HoshmandNavgan { get; set; }
        public string Sh_Plak { get; set; }
        public string Kamion { get; set; }
        public string Sh_Sokht { get; set; }
        public string Tel { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string CodePosti { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime DateRegister { get; set; }
        public int UserID_FK { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public byte[] PersonImg { get; set; }


        public virtual ICollection<SendMessages> SendMessages { get; set; }
    }
}