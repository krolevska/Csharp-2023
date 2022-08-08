using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Find: ");
            string str = Console.ReadLine();
            FindAndReplaceManager.FindNext(str);
        }
    }

    static class FindAndReplaceManager
    {
        static public void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
        }
    }

    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Search line: " + str);
        }
    }
}
