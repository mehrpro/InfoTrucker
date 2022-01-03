using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IMenuItemRepository
    {

    }

    public class MenuItemRepository :IMenuItemRepository
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IDbSet<MenuItem> _menuItems;

        public MenuItemRepository(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            _menuItems = _unitofWork.Set<MenuItem>();
        }
    }

}