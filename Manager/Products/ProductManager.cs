using Microsoft.EntityFrameworkCore;
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
        public async Task<ICollection<Product>> GetAllProductsAsync()
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

        public async Task<Product> GetProductById(int ProductId) => await _context.Products.Include(st => st.Category).FirstOrDefaultAsync(st => st.ProductID == ProductId);

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
        
    }
} 
