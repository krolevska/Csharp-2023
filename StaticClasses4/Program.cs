using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses4
{
    class Program
    {
        static void Main()
        {
            int[] array = { 5, 1, 4, 2, 3, 6 };
            array.SortUp();
            foreach (int i in array)
                Console.Write(i + " ");
        }
    }
}
