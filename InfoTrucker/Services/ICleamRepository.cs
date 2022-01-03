using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface ICleamRepository
    {

    }

    public class CleamRepository : ICleamRepository
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IDbSet<Cleam> _cleams;

        public CleamRepository(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            _cleams = _unitofWork.Set<Cleam>();
        }
    }
}