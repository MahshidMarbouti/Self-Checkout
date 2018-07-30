using System;
namespace Self_Checkout
{
    public class Shopping_Cart_Item
    {
        public Product ProductItem;
        public int Quantity;
        public Shopping_Cart_Item(Product product, int quantity)
        {
            ProductItem = product;
            Quantity = quantity;
        }

    }
}
