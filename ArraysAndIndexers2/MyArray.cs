using System;

namespace ArraysAndIndexers2
{
    class MyArray
    {
        int[] array;

        public MyArray(int n)
        {
            array = new int[Math.Abs(n)];
            Random random = new Random();
            Console.Write("The array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 40);
                Console.Write("{0}, ", array[i]);
            }
            Console.WriteLine();
        }

        public void Min()
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
            }
            Console.WriteLine("Min = {0}. ", min);
        }
        public void Max()
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
            }
            Console.WriteLine("Max = {0}. ", max);
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            Console.WriteLine("Sum = {0}. ", sum);
            return sum;
        }
        public void Avarage()
        {
            Console.WriteLine("Average = {0}", Sum()/array.Length);
        }

        public void Odds()
        {
            Console.Write("All odds: ");
            for (int i = 0; i < array.Length; i++)
                if (array[i]%2 != 0)
                    Console.Write("{0}, ", array[i]);
        }
    }
}
