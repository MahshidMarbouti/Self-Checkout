using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Self_Checkout.DataLayer;
using Self_Checkout.DataLayer.Interfaces;
using Self_Checkout.Interfaces;

namespace SelfCheckout
{
    public static class ServiceLocator
    {
        static Dictionary<Type,Type> TypeMapper = new Dictionary<Type,Type>();

        public static void RegisterAll()
        {
            TypeMapper.Add(typeof(IPrinter), typeof(ConsolePrinter) );
            TypeMapper.Add(typeof(IProductParser), typeof(ProductParser) );
            TypeMapper.Add(typeof(ITextReader), typeof(TextReader));
        }

        public static object Resolve(Type t)
        {
            return Activator.CreateInstance(TypeMapper[t]);
        }
    }
}