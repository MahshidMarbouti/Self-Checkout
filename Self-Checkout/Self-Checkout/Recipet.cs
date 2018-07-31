using System;
namespace SelfCheckout
{
    public class Recipet
    {
        public int Id { get; set; }
        public static int NextId;
        public string Address { get; set; }
        public ShoppingCart Cart { get; set; }
        public static string address = "ABC";

        public Recipet( ShoppingCart cart)
        {
            Id = NextId;
            NextId++;
            Cart = cart;
        }

    }
}
