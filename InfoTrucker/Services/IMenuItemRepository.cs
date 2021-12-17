using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IMenuItemRepository : IRepositoryBase<MenuItem>
    {

    }

    public class MenuItemRepository : RepositoryBase<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(DbContext context) : base(context)
        {

        }
    }

}