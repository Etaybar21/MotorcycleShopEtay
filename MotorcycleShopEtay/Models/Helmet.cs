namespace MotorcycleShopEtay.Models
{
    public enum HelmetType
    {
        half, full
    }
    public enum HelmetSize
    {
        XS,S,M,L,XL
    }
    public class Helmet: Product
    {

        public HelmetType? Type { get; set; }
        public string Color { get; set; }
        public HelmetSize? HelmetSize { get; set; }

    }
}
