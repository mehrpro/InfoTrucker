using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IPublicTypeRepository
    {

    }

    public class PublicTypeRepository : IPublicTypeRepository
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IDbSet<PublicType> _publicTypes;

        public PublicTypeRepository(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            _publicTypes = _unitofWork.Set<PublicType>();
        }
    }
}