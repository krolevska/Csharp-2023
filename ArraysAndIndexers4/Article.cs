using System;

namespace ArraysAndIndexers4
{
    class Article
    {
        double price;

        public string Name { get; private set; }
        public string Shop { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Price cannot be below zero");
            }
        }
        public Article(string name)
        {
            Name = name;
        }
        public Article(string name, string shop, double price)
        {
            Name = name;
            Shop = shop;
            Price = price;
        }
        public string Info()
        {
            return string.Format("{0} from {1} costs {2} UAH. ", Name, Shop, Price);
        }
    }

}
