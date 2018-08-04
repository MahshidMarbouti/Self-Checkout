namespace Self_Checkout.Models.Product
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
            const int LineSize = 4;
                
            var items = line.Split(',');

            if (items.Length!=LineSize){
                throw new System.InvalidOperationException($"Each line should have {LineSize} items separated by comma.");
            }
            int tempId;
            if (!int.TryParse(items[0], out tempId)){
                throw new System.InvalidCastException($"Id must be an integet value, current value is {items[0]}");
            }
            return new Product(int.Parse(items[0]), new ProductType(items[1]), int.Parse(items[2]), items[3]);
        }
    }
}