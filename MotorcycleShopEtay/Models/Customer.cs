namespace MotorcycleShopEtay.Models
{
    public enum DriverLisence
    {
        A,A1,A2
    }
    public class Customer
    {
        public int Id { get; set; }
        public int CustomerID { get; set; } 
        public string Name { get; set; }    
        public string Address { get; set; }
        public string City { get; set; }
        public DateOnly BirthDate { get; set; }  
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public DriverLisence? DriverLisence { get; set; }

    }
}
