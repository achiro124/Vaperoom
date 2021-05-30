
using System.Threading.Tasks;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Manager.Accounts
{
    public interface IAccountManager
    {

        public Task<User> GetUser(LoginModel model);

        public Task<User> GetUser1(RegisterModel model);

        public Task AddUsers(RegisterModel model);

    }
}
