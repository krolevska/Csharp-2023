using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics3
{
    class MyDictionary<TKey, TValue>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int length;

        public int Length
        {
            get { return length; }
        }

        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            length = n;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "Attemp to reach out of array. ";
            }
        }

        public void Add(int i, TKey k, TValue l)
        {
            key[i] = k;
            value[i] = l;
        }
    }
}
