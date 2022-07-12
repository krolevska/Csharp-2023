using System;

namespace MyFirstOOProgram
{
    //In your project, create two classes named MyClassA and MyClassB.
    //In each of the classes, create one string field and one method that displays the value of the field on the console screen.

    class MyClassA
    {
        public string field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }
    
    class MyClassB
    {
        public string field;

        public void Method()
        {
            Console.WriteLine(field);
        }

    }
    
    //In the Main method, create instances of the MyClassA and MyClassB classes,
    //assign values to the instance fields, and call the methods.
    
    class Program
    {
        static void Main()
        {
            MyClassA a = new MyClassA();
            MyClassB b = new MyClassB();

            a.field = "love";
            b.field = "sadness";

            a.Method();
            b.Method();

            Console.ReadKey();
        }
    }
}