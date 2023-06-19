using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public class ShopIsClosedException : Exception
    {
        public ShopIsClosedException(string message) : base(message)
        {
        }
    }

    public class OutOfStockException : Exception
    {
        public OutOfStockException(string message) : base(message)
        {
        }
    }

    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }
}
