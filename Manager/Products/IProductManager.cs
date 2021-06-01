using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Manager.Products
{
    public interface IProductManager 
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductById(int ProductId);
        Task<List<Product>> GetByCategory(string Category);
        List<Product> GetByType(List<Product> products,int Type);
        List<Product> Sorting(List<Product> products, string Type);
        string GetNameTypeProduct(int Type);
        Task<List<Product>> Search(string Name);
    }
}
