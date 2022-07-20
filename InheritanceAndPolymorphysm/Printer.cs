using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphysm
{    
    //Create a Printer class.
    //In the class body, create a void Print(string value)
    //method that prints the value to the screen argument.


    class Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }
    }
}
