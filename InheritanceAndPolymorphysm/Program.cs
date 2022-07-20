using System;

namespace InheritanceAndPolymorphysm
{

    class Program
    {
        public static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Hello World");

            DerivedPrinter printerNew = new DerivedPrinter();
            printerNew.Print("Hello World2");

            Printer newPrinter = new DerivedPrinter();
            newPrinter.Print("Hello World3");

            DerivedPrinter printerThree = (DerivedPrinter)newPrinter;
            printerThree.Print("Hello World4");
        }
      
    }

    //Implement the possibility that
    //in the case of inheritance from this class of other classes,
    //and calling corresponding method of their instance,
    //the strings passed as arguments to the methods,
    //displayed in different colors.
    //Be sure to use type casting.
}