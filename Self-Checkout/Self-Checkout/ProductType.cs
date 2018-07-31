namespace SelfCheckout
{
    public class ProductType
    {     
        public string Name { get; private set; }
        public ProductType(string name){
            Name = name;
        }
    }
}