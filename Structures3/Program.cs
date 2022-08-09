using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures3
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }
        static void StructTaker(Mystruct mystruct)
        {
            mystruct.change = "changed";
        }

        static void Main()
        {
            Mystruct mystruct = new Mystruct();
            mystruct.change = "not changed";

            MyClass myClass = new MyClass();
            myClass.change = "not changed";

            StructTaker(mystruct);
            ClassTaker(myClass);

            Console.WriteLine("MyStruct " + mystruct.change);
            Console.WriteLine("MyClass " + myClass.change);
        }
    }

    class MyClass
    {
        public string change;
    }

    struct Mystruct
    {
        public string change;
    }
}
