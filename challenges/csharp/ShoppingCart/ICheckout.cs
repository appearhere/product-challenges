using System;

namespace ShoppingCart
{
    public interface ICheckout
    {
        void Scan(char item);
        int Total();
    }
}
