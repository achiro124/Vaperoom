using Microsoft.EntityFrameworkCore;
using NewKinoHub.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Storage
{
    public class MvcVapeShopContext : DbContext
    {
        public MvcVapeShopContext(DbContextOptions<MvcVapeShopContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Product_Img> Product_Imgs { get; set; }
        public DbSet<Review> Reviews { get; set; }


    }
}
