﻿using System;
namespace SelfCheckout
{
    public class Payment
    {
        public PaymentType Type;
        public float Amount{ get; set; }
        public Payment(PaymentType type, float amount){
            Amount = amount;
            Type = type;
            
        }
        public bool processPayment()
        {

            return true; 
        }
    }
}
