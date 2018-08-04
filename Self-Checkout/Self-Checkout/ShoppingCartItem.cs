using System;
using Self_Checkout.Models.Product;

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
