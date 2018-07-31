using System;
namespace SelfCheckout
{
    public class Recipet
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public ShoppingCart Cart { get; set; }
    
        public Recipet(int id, ShoppingCart cart, string address = "ABC")
        {
            Id = id;
            Cart = cart;
            Address = address;
        }
       
}
