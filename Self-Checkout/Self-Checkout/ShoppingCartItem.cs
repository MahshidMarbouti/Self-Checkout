using System;
namespace SelfCheckout
{
    public class ShoppingCartItem
    {
        public Product ProductItem;
        public int Quantity;
        public ShoppingCartItem(Product product, int quantity = 0)
        {
            ProductItem = product;
            Quantity = quantity;
        }

    }
}
