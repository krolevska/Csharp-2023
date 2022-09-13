using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegates2
{

    public delegate int Operator(int a, int b);
    class Program
    {
        static void Main()
        {
            Console.Write("A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("+, -, *, /: ");
            string oper = Console.ReadLine();
            Console.Write("B:");
            int b = Convert.ToInt32(Console.ReadLine());

            Operator add = (a, b) => { return a + b; };
            Operator mul = (a, b) => { return a * b; };
            Operator div = (a, b) => { if (a != 0 && b != 0) { return a / b; } else { return 0; } };
            Operator sub = (a, b) => a - b;

            int result;
            switch (oper)
            {
                case "+":
                    result = add(a, b);
                    break;
                case "*":
                    result = mul(a, b);
                    break;
                case "/":
                    result = div(a, b);
                    break;
                case "-":
                    result = sub(a, b);
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine(result);

        }
    }
}
