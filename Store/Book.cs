using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public class Book
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public bool IsOnSale { get; set; }
        public int SalePrice { get; set; } // Поле для збереження зниженої ціни

        public Book(string name, string type, int price, bool isOnSale)
        {
            Name = name;
            Type = type;
            Price = price;
            IsOnSale = isOnSale;
            SalePrice = (int)(price * 0.85); // Обчислення зниженої ціни
        }
    }
}
