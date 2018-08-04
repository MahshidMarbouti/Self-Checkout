using SelfCheckout;

namespace Self_Checkout.Models.Payment
{
    public class Recipet
    {
        public int Id { get; }
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
