namespace MotorcycleShopEtay.Models
{
    public enum MotorcycleType
    {
        Motocross, Road, City, Supermoto
    }
    public enum MotorcycleGear
    {
        auto,manual
    }
    public class Motorcycle : Product
    {
        public int Engine { get; set; } 
        public int MaxSpeed { get; set; }
        public int NumGearShift { get; set; }
        public string Color { get; set; }
        public MotorcycleGear? Gear { get; set; }
        public MotorcycleType? Type { get; set; }
    }
}
