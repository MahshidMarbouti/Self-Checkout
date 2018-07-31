using System;
namespace Self_Checkout
{
    public class Shopping_Cart_Item
    {
        public Product ProductItem;
        public int Quantity;
        public Shopping_Cart_Item(Product product, int quantity = 0)
        {
            ProductItem = product;
            Quantity = quantity;
        }

    }
}
