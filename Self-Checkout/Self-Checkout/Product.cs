namespace Self_Checkout
{
    public class Product
    {
        public int ID;
        public ProductType Type;
        public int Price;
        public string Name;
        public Product(int id, ProductType type, int price, string name){
            ID = id;
            Type = type;
            Price = price;
            Name = name;
        }
    }
}