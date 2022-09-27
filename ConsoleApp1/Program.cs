using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Give me array scope: ");
            int u = Convert.ToInt32(Console.ReadLine());

            var list = new MyList<int>(u);

            var t = new Random();
            for (int x = 0; x < u; x++)
            {
                list.Add(x, t.Next(100));
            }
            Console.WriteLine("Array: ");
            int[] f = list.GetArray();

            for (int i = 0; i < f.Length; i++)
            {
                Console.Write("{0} ", f[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Array Length: {0}", list.Length);
        }
    }
}
