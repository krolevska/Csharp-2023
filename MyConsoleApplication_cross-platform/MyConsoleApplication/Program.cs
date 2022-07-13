using System;
using MyPackage;

namespace MyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPackage.Console instance = new MyPackage.Console();
            System.Console.WriteLine("... some results ...");
            double sqrt = Math.Sqrt(16);
        }
    }
}
