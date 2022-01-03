using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using InfoTrucker.DTO;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;

namespace InfoTrucker.Services
{
    public interface IUserApplication
    {
        void CreateUser(ApplicationUser applicationUser);
        IList<ApplicationUser> GetAllUsers();
    }

    public class UserApplication : IUserApplication
    {
        private IUOW _uow;
        private readonly IMapper _mapper;
        private IDbSet<ApplicationUser> _applicationUsers;

        public UserApplication(IUOW uow)
        {
            _uow = uow;
         
            _applicationUsers = _uow.Set<ApplicationUser>();
        }


        public void CreateUser(ApplicationUser applicationUser)
        {
            

            _applicationUsers.Add(applicationUser);
        }

        public IList<ApplicationUser> GetAllUsers()
        {
            return _applicationUsers.ToList();
        }
    }
}