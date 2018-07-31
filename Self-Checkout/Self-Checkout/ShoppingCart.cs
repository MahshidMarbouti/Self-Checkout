using System;
using System.Collections.Generic; 
namespace SelfCheckout
{
    public class ShoppingCart
    {
        private int ID;
        public List<ShoppingCartItem> items;
        public ShoppingCart()
        {
            ID = 0;
            items = new List<ShoppingCartItem>();
        }
        public void add(ShoppingCartItem item)
        {
            items.Add(item);
        }

        public void remove(ShoppingCartItem item)
        {
            items.Remove(item);
        }
    }
}
