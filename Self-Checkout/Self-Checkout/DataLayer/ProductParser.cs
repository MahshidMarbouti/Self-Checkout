using SelfCheckout;
using Self_Checkout.DataLayer.Interfaces;
using Self_Checkout.Models.Product;

namespace Self_Checkout.DataLayer
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
