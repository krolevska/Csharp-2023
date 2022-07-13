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
            a.field = 1;
            Console.WriteLine(a.field);
            a.Method();

            MyClass b = new MyClass();
            b.field = 2;
            Console.WriteLine(b.field);
            b.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
