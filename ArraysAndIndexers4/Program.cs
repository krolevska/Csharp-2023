using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndIndexers4
{
    class Program
    {
        static void Main()
        {
            Console.Write("How big is the store? ");
            int size = Convert.ToInt32(Console.ReadLine());

            Store store = new Store(size);

            for (int index = 0; index < size; index++)
            {
                Console.Write("\nName of the article: ");
                string name = Console.ReadLine();

                Console.Write("\nName of the shop: ");
                string shop = Console.ReadLine();

                Console.Write("\nPrice of the article: ");
                double price = Convert.ToDouble(Console.ReadLine());

                store.AddArticle(new Article(name, shop, price), index);
            }

            Console.Write("\nWhat are you looking for? ");

            int search = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n{0}", store[search]);
            
        }
    }
}
