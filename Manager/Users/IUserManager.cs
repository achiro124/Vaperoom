using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Manager.Users
{
    public interface IUserManager
    {
        Task<User> GetUser(string Email);
        byte[] GetImage(string Email);
        bool ImageNull(string Email);
        Task AddInBasket(string Email, int ProductId, int Hidden);

    }
}
