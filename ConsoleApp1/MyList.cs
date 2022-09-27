using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics4
{

    class MyList<T>
    {
        private readonly int length;
        private readonly T[] array;

        public int Length
        {
            get { return length; }
        }
        public MyList(int n)
        {
            array = new T[n];
            length = array.Length;
        }

        public void Add(int i, T a)
        {
            array[i] = a;
        }
        public T this[int i]
        {
            get { return array[i]; }
        }
    }

}
