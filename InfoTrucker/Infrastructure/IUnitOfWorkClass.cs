using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoTrucker.ServiceReference1;



namespace InfoTrucker.Infrastructure
{
    public interface IUnitOfWorkClass
    {
        tsmsServiceClient SMSClient { get; }

    }

    public class UnitOfWorkClass : IUnitOfWorkClass
    {
        private tsmsServiceClient _smsClient;

        public UnitOfWorkClass()
        {
            _smsClient = new tsmsServiceClient();
        }

        public tsmsServiceClient SMSClient => _smsClient;

    }
}
