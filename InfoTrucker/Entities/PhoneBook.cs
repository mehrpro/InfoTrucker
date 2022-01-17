namespace InfoTrucker.Entities
{
    public class PhoneBook
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string LName { get; set; }
        public string Mobile { get; set; }
        public string Mobile2 { get; set; }
        public string Phone { get; set; }
        public string Addres { get; set; }
        public string postalCode { get; set; }
        public string Jobs { get; set; }
        public string Description { get; set; }
        public int? DriverID_FK { get; set; }
        public int CenterID_FK { get; set; }
        public Center Center { get; set; }
    }

}
