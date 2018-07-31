namespace SelfCheckout
{
    public interface IProductParser
    {
        Product ParseLine(string line);
    }
}