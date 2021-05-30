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
        
        
    }
} 
