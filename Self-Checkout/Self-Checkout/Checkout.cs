using System;
using System.Linq;

namespace Self_Checkout
{
    public class Checkout
    {
        ShoppingCart Shoppingcart;
        DateTime Date;
        int ID;
        public Checkout(ShoppingCart shopping, DateTime date)
        {
            Date = date;
        }
        public void add(int ID){
           
            if ((Shoppingcart.items.Where(x => x.ProductItem.ID == ID).Select(y => { y.Quantity += 1; return y; }).ToList())== null)
            {
                DataLayer reader = new DataLayer();
                Product pr = reader.FindProduct(ID);
                Shopping_Cart_Item newItem = new Shopping_Cart_Item(pr);
                Shoppingcart.add(newItem);
            }
           
        } 

        public int Generante_Reciept()
        {
            Recipet receipt = new Recipet(ID, Shoppingcart);
            int price = receipt.Print_Reciept();
            return price;

        }
        public bool processPayment(PaymentType type, float amount)
        {
            Payment payment = new Payment(type, amount);
            return payment.processPayment();
                          

        }
    }
}
