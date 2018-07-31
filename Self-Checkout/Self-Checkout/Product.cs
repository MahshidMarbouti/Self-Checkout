namespace SelfCheckout
{
    public class Product
    {
        public int Id;
        public ProductType Type;
        public int Price;
        public string Name;
        public Product(int id, ProductType type, int price, string name){
            Id = id;
            Type = type;
            Price = price;
            Name = name;
        }
    }
}