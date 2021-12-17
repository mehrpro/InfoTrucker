using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface ICleamRepository : IRepositoryBase<Cleam>
    {

    }

    public class CleamRepository : RepositoryBase<Cleam>, ICleamRepository
    {
        public CleamRepository(DbContext context) : base(context)
        {

        }
    }
}