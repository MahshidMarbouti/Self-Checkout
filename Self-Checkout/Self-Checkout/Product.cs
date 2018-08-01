namespace SelfCheckout
{
    public class Product
    {
        
        public ProductType Type { get; private set; }
        public int Price{ get; private set; }
        public string Name{ get; private set; }
        public int Id { get; private set; }
      
        private Product(int id, ProductType type, int price, string name){
            Id = id;
            Type = type;
            Price = price;
            Name = name;
        }

        public static Product CreateFromLine(string line){
            var items = line.Split(',');
            return new Product(int.Parse(items[0]), new ProductType(items[1]), int.Parse(items[2]), items[3]);
        }
    }
}