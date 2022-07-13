using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass1
{
    class Classes
    {
        public static void Main(string[] args)
        {
            MyClass1 a = new MyClass1();

            MyClass2.MyClass2 b = new MyClass2.MyClass2();

            a.Method();
            b.Method();
        }
    }
}
//In the Main method, create instances of the class MyClass1 and MyClass2.

//For an instance of MyClass2, use a private import with the fully qualified name.

//Call the methods you created on class instances.
