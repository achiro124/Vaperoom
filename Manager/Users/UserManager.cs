using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Storage;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Manager.Users
{
    public class UserManager : IUserManager
    {
        private readonly MvcVapeShopContext _context;
        public UserManager(MvcVapeShopContext context)
        {
            _context = context;
        }
        public async Task<User> GetUser(string Email) => await _context.Users.Include(st => st.Basket).FirstOrDefaultAsync(st => st.Email == Email);

        public bool ImageNull(string Email)
        {
            return _context.Users.FirstOrDefault(st => st.Email == Email).Image == null ? true : false;
        }

        public byte[] GetImage(string Email)
        {
            return _context.Users.FirstOrDefault(st => st.Email == Email).Image;
        }

        public async Task AddInBasket(string Email, int ProductId, int Hidden)
        {
            if (_context.Users.Include(st => st.Basket).FirstOrDefault(st => st.Email == Email).Basket == null)
            {
                Basket basket = new Basket();
                basket.Products.Add(_context.Products.FirstOrDefault(st => st.ProductID == ProductId));
                _context.Users.FirstOrDefault(st => st.Email == Email).Basket = basket;
                _context.Users.FirstOrDefault(st => st.Email == Email).BasketId = basket.BasketId;
                _context.Users.FirstOrDefault(st => st.Email == Email).Basket.NumProduct.Add(Hidden);
            }
            else
            {
                _context.Users
                        .FirstOrDefault(st => st.Email == Email)
                        .Basket
                        .Products
                        .Add(_context.Products.FirstOrDefault(st => st.ProductID == ProductId));
            }
            await _context.SaveChangesAsync();
        }
    }
}
