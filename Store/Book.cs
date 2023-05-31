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

        public Book(string name, string type, int price)
        {
            Name = name;
            Type = type;
            Price = price;
        }
    }
}
