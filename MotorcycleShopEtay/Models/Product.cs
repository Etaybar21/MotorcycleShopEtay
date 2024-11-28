using System.ComponentModel.DataAnnotations;

namespace MotorcycleShopEtay.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brend { get; set; }
        public int Price { get; set; }
    }
}
