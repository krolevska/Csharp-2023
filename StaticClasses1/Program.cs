using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Give me first number (use ',' for decimal point): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose operation: +, -, *, /?");
            string operation = Console.ReadLine();
            Console.WriteLine("Give me second number (use ',' for decimal point): ");
            double b = Convert.ToDouble(Console.ReadLine());


            switch (operation)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}.",a,operation,b,Calculator.Sum(a, b));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}.", a, operation, b, Calculator.Extract(a, b));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}.", a, operation, b, Calculator.Multiply(a, b));
                    break;
                case "/":
                    if (b != 0) { Console.WriteLine("{0} {1} {2} = {3}.", a, operation, b, Calculator.Divide(a, b)); } else { Console.WriteLine("Cannot divide by zero. "); }
                    break;
                default:
                    Console.WriteLine("Try again. ");
                    break;
            }
        }
    }

    static class Calculator
    {
        static public double Sum(double a, double b)
        {
            return a + b;
        }
        static public double Extract(double a, double b)
        {
            return a - b;
        }
        static public double Multiply(double a, double b)
        {
            if (a == 0 || b == 0)
                return 0;
            else
                return a * b;
        }
        static public double Divide(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                return 0;
        }
    }
}
