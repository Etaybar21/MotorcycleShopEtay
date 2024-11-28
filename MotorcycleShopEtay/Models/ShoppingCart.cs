using System.ComponentModel.DataAnnotations;

namespace MotorcycleShopEtay.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ShoppingId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime ShoppingDate { get; set; }
        ICollection<Product> Products { get; set; }
    }
}
