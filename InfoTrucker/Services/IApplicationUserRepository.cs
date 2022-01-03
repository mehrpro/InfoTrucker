using System.Data.Entity;
using InfoTrucker.Entities;
using InfoTrucker.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;

namespace InfoTrucker.Services
{
    public interface IApplicationUserRepository
    {
        void Create(ApplicationUser applicationUser);
        void Update(ApplicationUser applicationUser);
        Task<bool> LoginTask(string username, string password);
    }

    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IDbSet<ApplicationUser> _applicationUsers;
        public ApplicationUserRepository(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            _applicationUsers = _unitofWork.Set<ApplicationUser>();
        }

        public void Create(ApplicationUser applicationUser)
        {
            _applicationUsers.Add(applicationUser);
        }

        public async void Update(ApplicationUser applicationUser)
        {
            var local = await _applicationUsers.FirstOrDefaultAsync(x => x.UserId == applicationUser.UserId);
            //Change(local, local == null);
        }

        public async Task<bool> LoginTask(string username, string password)
        {
            var usernameDe = ASE.EncryptString(username);
            var resultUsername = await _applicationUsers.FirstOrDefaultAsync(x => x.UserName == usernameDe);
            if (resultUsername != null)
            {
                var passwordDe = ASE.EncryptString(password);
                if (resultUsername.UserPassword == passwordDe)
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