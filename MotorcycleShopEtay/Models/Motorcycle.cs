namespace MotorcycleShopEtay.Models
{
    public class Motorcycle : Products
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
