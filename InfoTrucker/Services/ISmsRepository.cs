using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface ISmsRepository : IRepositoryBase<SendMessages>
    {

    }

    public class SmsRepsitory : RepositoryBase<SendMessages>, ISmsRepository
    {
        public SmsRepsitory(DbContext context) : base(context)
        {

        }
    }
}
