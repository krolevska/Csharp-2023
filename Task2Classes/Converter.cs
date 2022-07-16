using System;

namespace Classes
{
    class Converter
    {
        double ammount;
        public double Amount { get; set; }

        readonly double usd, eur, plz;

        public Converter(double usd, double eur, double plz)
        {
            this.usd = usd;
            this.eur = eur;
            this.plz = plz;
        }

        public void Result()
        {
            Console.WriteLine("{0} USD, {1} EUR, {2} PLZ. ", usd*Amount, eur*Amount, plz*Amount);
        }
    }
}