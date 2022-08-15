using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("\nВведи номер кольору для тексту: " +
                "\n1 — блакитний" +
                 "\n2 — зелений" +
                  "\n3 — червоний" +
                   "\n4 — жовтий" +
                    "\n5 — блакитний" +
                     "\n6 — бузковий" +
                      "\n7 — білий" + "\n");

            int color = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("\nНапиши своє послання? ");

            string stroke = Console.ReadLine();

            MyClass.Print(stroke, color);

        }
    }

    static class MyClass
    {
        public static void Print(string stroke, int color)
        {
            switch (color)
            {
                case (int)Colors.blue: Console.ForegroundColor = ConsoleColor.Blue; break;
                case (int)Colors.red: Console.ForegroundColor = ConsoleColor.Red; break;
                case (int)Colors.yellow: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case (int)Colors.green: Console.ForegroundColor = ConsoleColor.Green; break;
                case (int)Colors.white: Console.ForegroundColor = ConsoleColor.White; break;
                case (int)Colors.cyan: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case (int)Colors.magenta: Console.ForegroundColor = ConsoleColor.Magenta; break;
                default: Console.Write("\nВиведений тобою рядок буде стандартного кольору. "); break;
            }

            Console.WriteLine(stroke);
        }
    }

    enum Colors
    {
        blue,
        green,
        red,
        yellow,
        cyan,
        magenta,
        white
    }
}
