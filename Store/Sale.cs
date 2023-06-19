using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public interface ISale
    {
        void NotifyProductAvailable(string productName);
        void NotifyProductOrdered(string productName);
        void ProcessOrder(string productName);
    }

    public class Sale : ISale
    {
        public event Action<string> ProductAvailable;
        public event Action<string> ProductOrdered;

        public void NotifyProductAvailable(string productName)
        {
            ProductAvailable?.Invoke(productName);
        }

        public void NotifyProductOrdered(string productName)
        {
            ProductOrdered?.Invoke(productName);
        }

        public void ProcessOrder(string productName)
        {
            // Обробка замовлення
        }
    }

    public class NullSale : ISale
    {
        public void NotifyProductAvailable(string productName)
        {
            // Пуста реалізація
        }

        public void NotifyProductOrdered(string productName)
        {
            // Пуста реалізація
        }

        public void ProcessOrder(string productName)
        {
            // Пуста реалізація
        }
    }
}