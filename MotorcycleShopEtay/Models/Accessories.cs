namespace MotorcycleShopEtay.Models
{
    public class Accessories: Products
    {
        public string Description { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
