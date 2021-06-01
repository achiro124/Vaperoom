using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewKinoHub.Manager;
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
        public async Task<User> GetUser(string Email) => await _context.Users.Include(st => st.Basket).ThenInclude(st=>st.Products).FirstOrDefaultAsync(st => st.Email == Email);

        public bool ImageNull(string Email)
        {
            return _context.Users.FirstOrDefault(st => st.Email == Email).Image == null ? true : false;
        }

        public List<int> GetNumberProduct(int BasketId)
        {
            return _context.Baskets.FirstOrDefault(st => st.BasketId == BasketId).NumProduct;
        }
        public byte[] GetImage(string Email)
        {
            return _context.Users.FirstOrDefault(st => st.Email == Email).Image;
        }

        [HttpPost]
        public async Task AddInBasket(string Email, int ProductId, int Hidden)
        {   
            if(Hidden == 0)
            {
                Hidden++;
            }
            if (_context.Users.Include(st => st.Basket).ThenInclude(st=>st.Products).FirstOrDefault(st => st.Email == Email).Basket == null)
            {
                Basket basket = new Basket();
                basket.Products.Add(_context.Products.FirstOrDefault(st => st.ProductID == ProductId));
                basket.NumProduct.Add(Hidden);
                _context.Users.FirstOrDefault(st => st.Email == Email).Basket = basket;
            }
            else
            {
                _context.Users.FirstOrDefault(st => st.Email == Email).Basket.Products.Add(_context.Products.FirstOrDefault(st => st.ProductID == ProductId));
            }
            await _context.SaveChangesAsync();
        }

        public int GetAllPrice(string Email)
        {
            int sum = 0;
            foreach(var price in _context.Users.Include(st=>st.Basket).ThenInclude(st=>st.Products).FirstOrDefault(st=>st.Email == Email).Basket.Products)
            {
                sum += price.Value;
            }
            return sum;
        }

        public async Task DeleteProductByBasket(int ProductId, int BasketId)
        {
            var itemToRemove = _context.Baskets
                                       .Include(st => st.Products)
                                       .Include(st => st.Users)
                                       .FirstOrDefault(st => st.BasketId == BasketId)
                                       .Products
                                       .FirstOrDefault(st => st.ProductID == ProductId);
            if(itemToRemove != null)
            {
                _context.Baskets.FirstOrDefault(st => st.BasketId == BasketId).Products.Remove(itemToRemove);
            }
            await _context.SaveChangesAsync();
        }

        [HttpPost]
        public async Task DeleteAllBasket(int BasketId)
        {
            _context.Baskets.Include(st => st.Products).Include(st => st.Users).FirstOrDefault(st => st.BasketId == BasketId).Products.Clear();

            await _context.SaveChangesAsync();
        }

        public int GetUserId(string Email)
        {
            if (Email != null)
                return _context.Users.FirstOrDefault(st => st.Email == Email).UserId;
            return 0;
        }

        [HttpPost]
        public async Task EditAccount(IFormFile mainPhoto, string name, DateTime DataB, string Email)
        {

            if (mainPhoto != null)
            {
                _context.Users.FirstOrDefault(st => st.Email == Email).Image = SaveImage.getByteImage(mainPhoto);
            }
            if (DataB.Year != 0001)
            {
                _context.Users.FirstOrDefault(st => st.Email == Email).DateOfBirthday = DataB;
            }
            if (name != null)
            {
                _context.Users.FirstOrDefault(st => st.Email == Email).Nickname = name;
            }
            await _context.SaveChangesAsync();
        }



    }
}
