namespace MotorcycleShopEtay.Models
{
    public class ShoppingCart
    {
        public int ShoppingId { get; set; }
        public int MotorcycleId { get; set; }
        public Motorcycle Motorcycle { get; set; }
        public int HelmetsId { get; set; }
        public Helmets Helmets { get; set; }
        public int AccessoriesId { get; set; }
        public Accessories Accessories { get; set; }
        public DateTime ShopingDate { get; set; }
    }
}
