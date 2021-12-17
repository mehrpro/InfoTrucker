﻿using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrucker.Services
{
    public interface IApplicationUserRepository : IRepositoryBase<ApplicationUser>
    {
        void Update(ApplicationUser applicationUser);
        Task<bool> LoginTask(string username, string password);
    }

    public class ApplicationUserRepository : RepositoryBase<ApplicationUser>, IApplicationUserRepository
    {
        public ApplicationUserRepository(DbContext context) : base(context)
        {
        }

        public async void Update(ApplicationUser applicationUser)
        {
            var local = await GetFirstOrDefaultAsync(x => x.UserId == applicationUser.UserId);
            Change(local, local == null);
        }

        public async Task<bool> LoginTask(string username, string password)
        {
            var resultUsername = await GetFirstOrDefaultAsync(x => x.UserName == username);
            if (resultUsername != null)
            {
                if (resultUsername.UserPassword == password)
                {
                    PublicValue.Fullname = resultUsername.FullName;
                    PublicValue.UserID = resultUsername.UserId;
                    return true;
                }
            }

            return false;
        }
    }
}