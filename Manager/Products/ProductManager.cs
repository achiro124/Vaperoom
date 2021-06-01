using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewKinoHub.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Storage;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Manager.Products
{
    public class ProductManager : IProductManager
    {
        private readonly MvcVapeShopContext _context;
        public ProductManager(MvcVapeShopContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products
                                 .Include(st=>st.Category)
                                 .ToListAsync();
        }

        public async Task<List<Product>> GetByCategory(string Category)
        {
            return await _context.Products
                                 .Include(st => st.Category)
                                 .Where(st => st.Category.Category_Name == Category)
                                 .ToListAsync();
        }

        public async Task<Product> GetProductById(int ProductId) => await _context.Products.Include(st => st.Imgs).Include(st => st.Category).Include(st=>st.Reviews).FirstOrDefaultAsync(st => st.ProductID == ProductId);

        public List<Product> GetByType(List<Product> products, int Type) => products.Where(st => (int)st.ProductType == Type).ToList();

        public List<Product> Sorting(List<Product> products, string Type)
        {
            if (Type == "ValueOne")
            {
                products = products.OrderBy(st => st.Value).ToList();
            }
            if (Type == "Second")
            {
                products = products.OrderByDescending(st => st.Value).ToList();
            }
            if (Type == "Raiting")
            {
                products = products.OrderByDescending(st => st.Score).ToList();
            }
            return products;
        }

        public string GetNameTypeProduct(int Type)
        {
            
            if(Type == 0)
            {
                return "GeekVape";
            }
            if (Type == 1)
            {
                return "SMOK";
            }
            if (Type == 2)
            {
                return "Logic_Compact";
            }
            if (Type == 3)
            {
                return "Солевые_жидкости";
            }
            if (Type == 4)
            {
                return "Щелочные_жидкости";
            }
            if (Type == 5)
            {
                return "Мехмоды";
            }
            if (Type == 6)
            {
                return "Аккамуляторы";
            }
            if (Type == 7)
            {
                return "Готовые_койлы";
            }
            return "1";
        }

        [HttpGet]
        public async Task<List<Product>> Search(string Name)
        {
            var product = await GetAllProductsAsync();
            if (!String.IsNullOrEmpty(Name) && Name != "")
            {
                product = product.Where(x => x.Name.Contains(Name)).ToList();
            }
            return product;
        }


        [HttpPost]
        public async Task AddReviews(int ProductId, string Email, string text)
        {
            var NickName = _context.Users.FirstOrDefault(st => st.Email == Email).Nickname;
            Review review = new Review();
            review.Description = text;
            review.ProductId = ProductId;
            review.UsersId = _context.Users.FirstOrDefault(st => st.Email == Email).UserId;
            review.Nickname = NickName;
            review.ImgUser = _context.Users.FirstOrDefault(st => st.Email == Email).Image;
            review.DateOfReview = DateTime.Now.ToString();
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReviews(int ProductId, int IdUser)
        {
            var itemToRemove = await _context.Reviews
                                             .Include(st => st.User)
                                             .Include(st => st.Product)
                                             .SingleOrDefaultAsync(st => st.ProductId == ProductId && st.UsersId == IdUser);
            if (itemToRemove != null)
            {
                _context.Reviews.Remove(itemToRemove);
            }

            await _context.SaveChangesAsync();
        }

        public bool UserReview(string Email, int ProductId)
        {
            bool p = false;
            if (Email != null)
            {
                foreach (var rev in _context.Reviews.Where(st => st.ProductId == ProductId))
                {
                    if (rev.UsersId == _context.Users.FirstOrDefault(st => st.Email == Email).UserId)
                    {
                        p = true;
                    }
                }
            }
            if (p)
            {
                return p;
            }
            else
            {
                return p;
            }
        }

        public int GetCoutBasket(string Email)
        {
            if(Email == null)
            {
                return 0;
            }
            else
            {
                return _context.Users.Include(st => st.Basket).ThenInclude(st => st.Products).FirstOrDefault(st => st.Email == Email).Basket.Products.Count();
            }
        }

        [HttpPost]
        public async Task EditReviews(int ProductId, int IdUser, string text)
        {
            if (text != null)
            {
                _context.Reviews.FirstOrDefault(st => st.ProductId == ProductId && st.UsersId == IdUser).Description = text;
                _context.Reviews.FirstOrDefault(st => st.ProductId == ProductId && st.UsersId == IdUser).DateOfReview = DateTime.Now.ToString();
            }
            await _context.SaveChangesAsync();
        }
    }
} 
