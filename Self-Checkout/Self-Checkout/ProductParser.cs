using System;
namespace SelfCheckout
{
    public class ProductParser:IProductParser
    {
        public Product ParseLine(string line)
        {
            var items = line.Split(',');
            var product = new Product(int.Parse(items[0]), new ProductType(items[1]), int.Parse(items[2]), items[3]);
            return product;
        }
    }
}
