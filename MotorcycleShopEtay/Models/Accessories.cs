namespace MotorcycleShopEtay.Models
{
    public enum SizeAccessories
    {
        XS,S,M,L,XL
    }
    public class Accessorie: Product
    {
        public string Description { get; set; }
        public SizeAccessories? size { get; set; }
        
    }
}
