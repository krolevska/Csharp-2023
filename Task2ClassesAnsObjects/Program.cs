using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine("Area is {0}, perimeter is {1}", rectangle.Area, rectangle.Perimeter);
        }
    }
}
