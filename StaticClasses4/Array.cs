using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses4
{
    static class Extend
    {
        static public void SortUp(this int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
                for (int j = intArray.Length - 1; j > i; j--)
                    if (intArray[i] > intArray[j])
                    {
                        int x = intArray[j];
                        intArray[j] = intArray[i];
                        intArray[i] = x;
                    }
        }
    }
}
