using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IPublicTypeRepository : IRepositoryBase<PublicType>
    {

    }

    public class PublicTypeRepository : RepositoryBase<PublicType>, IPublicTypeRepository
    {
        public PublicTypeRepository(DbContext context) : base(context)
        {
        }
    }
}