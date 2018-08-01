using System;
namespace SelfCheckout
{
    public class ProductParser:IProductParser
    {
        public Product ParseLine(string line)
        {
            var product = Product.CreateFromLine(line);
            return product;
        }
    }
}
