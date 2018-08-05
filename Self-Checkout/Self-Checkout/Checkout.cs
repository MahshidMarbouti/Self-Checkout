﻿using System;
using System.Linq;
using Self_Checkout.DataLayer;
using Self_Checkout.DataLayer.Interfaces;
using Self_Checkout.Interfaces;
using Self_Checkout.Models.Payment;

namespace SelfCheckout
{
    public class Checkout
    {
        private ShoppingCart _shoppingcart;
        private DateTime _date;
        private int _id;
        private IPrinter _iPrinter;
        public Checkout(IPrinter iPrinter)
        {
            _date = DateTime.Now;
            _shoppingcart = new ShoppingCart();
            _iPrinter = iPrinter;
        }
        public void Add(int productId)
        {
            var shoppingCartItemforProduct = _shoppingcart.items.SingleOrDefault(x => x.ProductItem.Id == productId);

            if (shoppingCartItemforProduct==null){
                // TODO: use IoC for dependency injection instead of newing classes (new is glue!!)
                //var textReader = (ITextReader)ServiceLocator.Resolve(typeof(ITextReader));
                
                var textReader = ServiceLocatorGeneric.Resolve<ITextReader>();
                
                var productParser = ServiceLocatorGeneric.Resolve<IProductParser>(); 
                
                var productRepository = new ProductRepository(textReader, productParser);

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
        public void GeneranteReciept()
        {
            var receipt = new Recipet(_shoppingcart);
            _iPrinter.Print(receipt);
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
