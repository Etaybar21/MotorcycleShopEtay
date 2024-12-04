﻿namespace MotorcycleShopEtay.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int ProductId {  get; set; }    
        public Product Product { get; set; }
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
