using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IMenuGroupRepository : IRepositoryBase<MenuGroup>
    {

    }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(DbContext context) : base(context)
        {

        }
    }
}