using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How big is the dictionary? ");
            int n = Convert.ToInt32(Console.ReadLine());

            var dictionary = new MyDictionary<string, string>(n);

            for (int i = 0; i < n; i++)
            {
                dictionary.Add(i, "table", "tavolo");
            }

            Console.WriteLine(new String('-', 20));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary.Length);
        }
    }
}
