using System;

namespace SelfCheckout
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Checkout newCheckout = new Checkout();
            newCheckout.Add(1);
            newCheckout.GeneranteReciept();
        }
    }
}
