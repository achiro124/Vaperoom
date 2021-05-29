using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Manager.Products
{
    public interface IProductManager 
    {
        Task<ICollection<Product>> GetAllProductsAsync();
    }
}
