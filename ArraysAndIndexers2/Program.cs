using System;

namespace ArraysAndIndexers2
{
    class Program
    {
        static void Main()
        {
            Console.Write("How big is the array? ");
            int n = Convert.ToInt32(Console.ReadLine());

            MyArray ar = new MyArray(n);

            ar.Min();
            ar.Max();
            ar.Avarage();
            ar.Odds();
        }
    }
}
