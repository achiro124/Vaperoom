using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Vaperoom.Manager.Accounts;
using Vaperoom.Storage;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Manager
{
    public class AccountManager : IAccountManager
    {
        private MvcVapeShopContext db;
        public AccountManager(MvcVapeShopContext context)
        {
            db = context;
        }

        public async Task AddUsers(RegisterModel model)
        {
            Basket basket = new Basket();
            db.Users.Add(new User { Nickname = model.Nickname, Email = model.Email, Password = model.Password,Basket = basket,BasketId = basket.BasketId});
            await db.SaveChangesAsync();
        }

        public async Task<User> GetUser(LoginModel model)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
            return user;
        }

        public async Task<User> GetUser1(RegisterModel model)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
            return user;
        }
    }
}
