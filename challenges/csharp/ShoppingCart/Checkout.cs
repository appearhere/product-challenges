using System;

namespace ShoppingCart
{
    public class Checkout : ICheckout
    { 
        private IRules _rules;

        public Checkout(IRules rules)
        {
            this._rules = rules;
        }

        public void Scan(char item)
        {
            throw new System.NotImplementedException();
        }

        public int Total()
        {
            throw new System.NotImplementedException();
        }
    }
}
