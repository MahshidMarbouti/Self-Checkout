using System;

namespace SelfCheckout
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceLocator.RegisterAll();
            ServiceLocatorGeneric.RegisterAll();
            ConsolePrinter printer = new ConsolePrinter();
            Console.WriteLine("Hello World!");
            Checkout newCheckout = new Checkout(printer);
            newCheckout.Add(1);
            newCheckout.Add(1);
            newCheckout.GeneranteReciept();
        }
    }
}
