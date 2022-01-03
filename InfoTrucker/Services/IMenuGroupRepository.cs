using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IMenuGroupRepository
    {

    }

    public class MenuGroupRepository : IMenuGroupRepository
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IDbSet<MenuGroup> _menuGroups;

        public MenuGroupRepository(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            _menuGroups = _unitofWork.Set<MenuGroup>();
        }
    }
}