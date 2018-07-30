using System;
using System.Collections.Generic; 
namespace Self_Checkout
{
    public class ShoppingCart
    {
        public int ID;
        public int Capacity;
        public List<Shopping_Cart_Item> items;
        public ShoppingCart(int id, int capacity)
        {
            ID = id;
            Capacity = capacity;
            items = new List<Shopping_Cart_Item>();
        }
        public List<Shopping_Cart_Item> add(Shopping_Cart_Item item)
        {
            items.Add(item);
            return items;
        }

        public List<Shopping_Cart_Item> remove(Shopping_Cart_Item item)
        {
            items.Remove(item);
            return items;
        }
    }
}
