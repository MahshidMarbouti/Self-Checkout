using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCheckout
{
    /// <inheritdoc />
    class Printer : IPrinter
    {
        /// <inheritdoc />
        void PrintReciept(Recipet recipet)
        {
            int rowTotal;
            int Total = 0;
            Console.WriteLine("Receipt Numer {0}", recipet.Id);
            Console.WriteLine("Address: {0}", recipet.Address);
            Console.WriteLine(DateTime.Now);
            foreach (var item in recipet.Cart.items)
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
