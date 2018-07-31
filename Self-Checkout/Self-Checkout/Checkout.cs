using System;
using System.Linq;

namespace SelfCheckout
{
    public class Checkout
    {
        private ShoppingCart _shoppingcart;
        private DateTime _date;
        private int _id;
        public Checkout()
        {
            _date = DateTime.Now;
            _shoppingcart = new ShoppingCart();
        }
        public void Add(int productId)
        {
            var shoppingCartItemforProduct = _shoppingcart.items.SingleOrDefault(x => x.ProductItem.Id == productId);

            if (shoppingCartItemforProduct==null){
                var textReader = new TextReader();
                var productRepository = new ProductRepository(textReader);

                //TODO: check for not found products
                var productInRepository = productRepository.FindById(productId);

                _shoppingcart.add(new ShoppingCartItem(productInRepository));
            }
            else{
                shoppingCartItemforProduct.Quantity++;
            }
      } 
        /// <summary>
        /// Generantes the reciept.
        /// </summary>
        /// <returns>The reciept.</returns>
        public int GeneranteReciept()
        {
            var receipt = new Recipet(_id, _shoppingcart);
            var price = receipt.Print_Reciept();
            return price;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns><c>true</c>, if payment was processed, <c>false</c> otherwise.</returns>
        /// <param name="type">Type.</param>
        /// <param name="amount">Amount.</param>
        public bool ProcessPayment(PaymentType type, float amount)
        {
            var payment = new Payment(type, amount);
            return payment.processPayment();
                          

        }
    }
}
