using System;

namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("USD: ");
            double usd = Convert.ToDouble(Console.ReadLine());

            Console.Write("EUR: ");
            double eur = Convert.ToDouble(Console.ReadLine());

            Console.Write("PLZ: ");
            double plz = Convert.ToDouble(Console.ReadLine());

            Converter converter = new Converter(usd, eur, plz);

            Console.Write("Input ammount in UAH: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            converter.Amount = amount;

            converter.Result();

        }
    }
}
