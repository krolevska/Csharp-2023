using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate int Summarizer(int a, int b);

    class Sum
    {
        public int GetSum(int a, int b)
        { return a + b; }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Write a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Sum sum = new Sum();
            int c = new Summarizer(sum.GetSum)(a,b);
            Console.WriteLine(c);
        }
    }
}
