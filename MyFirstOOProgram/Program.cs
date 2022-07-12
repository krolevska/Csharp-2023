using System;

namespace MyFirstOOProgram
{
    class MyClass
    {
        public int field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }
    class Program
    {
        static void Main()
        {
            MyClass a = new MyClass();
            MyClass b = new MyClass();

            a.field = 1;
            b.field = 2;

            Console.WriteLine(a.field);
            Console.WriteLine(b.field);

            a.Method();
            b.Method();

            Console.ReadKey();
        }
    }
}
//In your project, create two classes named MyClassA and MyClassB.
//In each of the classes, create one string field and one method that displays the value of the field on the console screen.
//In the Main method, create instances of the MyClassA and MyClassB classes,
//assign values to the instance fields, and call the methods.