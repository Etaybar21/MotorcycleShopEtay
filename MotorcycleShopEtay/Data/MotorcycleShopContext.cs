using Microsoft.EntityFrameworkCore;
using MotorcycleShopEtay.Models;

namespace MotorcycleShopEtay.Deta
{
    public class MotorcycleShopContext:DbContext
    {
        public MotorcycleShopContext(DbContextOptions<MotorcycleShopContext> options) : base(options)
        {
        }
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Helmet> Helmets { get; set; }
        public DbSet<Accessorie> Accessories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase> purchases { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}
