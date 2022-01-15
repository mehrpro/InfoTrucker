using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using InfoTrucker.ServiceReference1;



namespace InfoTrucker.Infrastructure
{
    public interface IUnitOfWorkClass
    {
        tsmsServiceClient SMSClient { get; }
        System.Configuration.Configuration Config { get; }

    }

    public class UnitOfWorkClass : IUnitOfWorkClass
    {
        private tsmsServiceClient _smsClient;
        private System.Configuration.Configuration _config;

        public UnitOfWorkClass()
        {
            _smsClient = new tsmsServiceClient();
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public tsmsServiceClient SMSClient => _smsClient;
        public System.Configuration.Configuration Config => _config;

    }
}
