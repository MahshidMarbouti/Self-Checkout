using SelfCheckout;
using Self_Checkout.Models.Product;

namespace Self_Checkout.DataLayer.Interfaces
{
    public interface IProductParser
    {
        Product ParseLine(string line);
    }
}