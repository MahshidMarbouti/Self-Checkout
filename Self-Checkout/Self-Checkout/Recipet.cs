using System;
namespace SelfCheckout
{
    public class Recipet
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public ShoppingCart Cart { get; set; }
        public Recipet(int id, ShoppingCart cart, string address = "ABC")
        {
            ID = id;
            Cart = cart;
            Address = address;
        }
        public int Print_Reciept()
        {
            int rowTotal;
            int Total = 0;
            Console.WriteLine("Receipt Numer {0}", ID);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine(DateTime.Now);
            foreach (var item in Cart.items)
            {
                rowTotal = item.ProductItem.Price * item.Quantity;
                Total += rowTotal;

                Console.WriteLine("Name, PricePerItem, Quantity, Total");
                Console.WriteLine($"Name {item.ProductItem.Name}, price is {item.ProductItem.Price}, Quantity is {item.Quantity}, Total is {rowTotal}");
            }
            Console.WriteLine($"Total amount to pay: {Total}");
            return Total;


        }
    }
}
