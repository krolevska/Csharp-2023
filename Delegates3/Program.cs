using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegates3
{

    class Program
    {
        public delegate int MyDelegate();
        public delegate double ArrayDelegate(MyDelegate[] a);

        static int GetRandom()
        {
            return new Random().Next(100);
        }
        static void Main()
        {
            Console.Write("How many elements of array do you want? ");
            int number = Convert.ToInt32(Console.ReadLine());
            var array = new MyDelegate[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom).Invoke();
            }
            ArrayDelegate b = delegate (MyDelegate[] a)
            {
                double sr = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sr += a[i].Invoke();
                }
                return sr / a.Length;
            };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Invoke()+" ");
            }
            Console.WriteLine("\nArithmetic mean is {0}",b(array));
        }
    }
}
