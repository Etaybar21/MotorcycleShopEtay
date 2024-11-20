using Microsoft.EntityFrameworkCore;
using MotorcycleShopEtay.Models;

namespace MotorcycleShopEtay.Deta
{
    public class MotorcycleShopContext:DbContext
    {
        public MotorcycleShopContext(DbContextOptions<MotorcycleShopContext> options) : base(options)
        {
            public DbSet<Motorcycle> Motorcycles { get; set; }
            public DbSet<Helmets> Helmets { get; set; }
            public DbSet<Accessories> Accessories { get; set; }
            public DbSet<Products> Products { get; set; }
            public DbSet<ShoppingCart> ShoppingCarts { get; set; }

    }
    }
}
