using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{

    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
    class Program
    {
        static void Main()
        {
            int i = MyClass<int>.FactoryMethod();

            Console.WriteLine(i.GetType().Name);

            Program p = MyClass<Program>.FactoryMethod();

            Console.WriteLine(p.GetType().Name);

        }
    }
}
