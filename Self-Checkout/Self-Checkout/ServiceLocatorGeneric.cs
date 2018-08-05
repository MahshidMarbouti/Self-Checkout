using System;
using System.Collections.Generic;
using Self_Checkout.DataLayer;
using Self_Checkout.DataLayer.Interfaces;
using Self_Checkout.Interfaces;

namespace SelfCheckout
{
    public static class ServiceLocatorGeneric
    {
        static Dictionary<Type,Type> TypeMapper = new Dictionary<Type,Type>();

        public static void RegisterAll()
        {
            TypeMapper.Add(typeof(IPrinter), typeof(ConsolePrinter) );
            TypeMapper.Add(typeof(IProductParser), typeof(ProductParser) );
            TypeMapper.Add(typeof(ITextReader), typeof(TextReader));
        }

        public static T Resolve<T>() 
        {
            return (T)Activator.CreateInstance(TypeMapper[typeof(T)]);
        }
        
        public static T Resolve<T>(object[] args) 
        {
            return (T)Activator.CreateInstance(TypeMapper[typeof(T)],args);
        }
    }
}