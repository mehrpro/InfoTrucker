namespace InfoTrucker.DTO
{
    public class ConnectionStrDTO
    {
        public string Server_Instance { get; set; }
        public string ServerName { get; set; }
        public string InstanceName { get; set; }
        public string DatabaseName { get; set; }

        public string UserID { get; set; }
        public string Password { get; set; }
        public bool WindowsAuthentication { get; set; }
    }
}