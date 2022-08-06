using System;
using System.Text;

namespace ArraysAndIndexers3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("How many rows do you want? ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many columns do you want? ");
            int m = Convert.ToInt32(Console.ReadLine());

            MyMatrix matr = new MyMatrix(n, m);
            matr.Show();

            Console.WriteLine("We can show only part of it. What is the first row? ");
            int startRow = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine("What is the first column? ");
            int startCol = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine("What is the last row? ");
            int endRow= Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine("What is the last column? ");
            int endCol = Convert.ToInt32(Console.ReadLine())-1;

            matr.ShowPart(startRow, startCol, endRow, endCol);
        }
    }
}
