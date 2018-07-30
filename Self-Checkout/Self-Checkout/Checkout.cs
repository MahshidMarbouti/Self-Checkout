using System;
namespace Self_Checkout
{
    public class Checkout
    {
        ShoppingCart Shoppingcart;
        DateTime Date;
        int ID;
        public Checkout(ShoppingCart shopping, DateTime date)
        {
            Shoppingcart = shopping;
            Date = date;
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
