namespace Self_Checkout.Models.Product
{
    public class ProductType
    {     
        public string Name { get; private set; }
        public ProductType(string name){
            Name = name;
        }
    }
}