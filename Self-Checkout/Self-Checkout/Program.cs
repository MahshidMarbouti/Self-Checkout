using System;

namespace SelfCheckout
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePrinter printer = new ConsolePrinter();
            Console.WriteLine("Hello World!");
            Checkout newCheckout = new Checkout(printer);
            newCheckout.Add(1);
            newCheckout.Add(1);
            newCheckout.GeneranteReciept();
        }
    }
}
