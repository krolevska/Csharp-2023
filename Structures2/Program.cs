using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures2
{
    class Program
    {
        static void Main()
        {
            Train[] trains = new Train[2];
            MyClass.AddArray(trains);

            Console.Write("\nInfo!");
            MyClass.Sort(trains);
            MyClass.Show(trains);

            Console.Write("\nSearch: ");
            MyClass.Search(trains, Convert.ToInt32(Console.ReadLine()));
        }
    }

    public struct Train
    {
        private string point;
        private int numberTrain;
        private DateTime time;

        public Train(string point, int numberTrain, DateTime time)
        {
            this.point = point;
            this.numberTrain = numberTrain;
            this.time = time;
        }

        public string Point
        {
            get { return point; }
        }
        public int NumberTrain
        {
            get { return numberTrain; }
        }
        public DateTime Time
        {
            get { return time; }
        }
    }

    public static class MyClass
    {
        public static void Sort(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
                for (int j = 0; j < trains.Length; j++)
                    if (trains[i].NumberTrain <= trains[j].NumberTrain)
                    {
                        Train x = trains[i];
                        trains[i] = trains[j];
                        trains[j] = x;
                    }


        }
        public static void Search(Train[] trains, int search)
        {
            bool ok = false;
            for (int i = 0; i < trains.Length; i++)
                if (trains[i].NumberTrain == search)
                {
                    Console.Write($"\nTrain {trains[i].NumberTrain} departs to {trains[i].Point} at {trains[i].Time}. ");
                    ok = true;
                }
            if (ok != true)
            {
                Console.Write("\nCannot find your train. ");
            }
        }
        public static void AddArray(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {

                Console.Write("\nTrain number: ");
                string trainNumber = Console.ReadLine();
                int number = string.IsNullOrEmpty(trainNumber) ? 0 : Convert.ToInt32(trainNumber);

                Console.Write("\nDestination: ");
                string point = Console.ReadLine();
                point = string.IsNullOrEmpty(point) ? "No destination given. " : point;


                Console.Write("\nTime of departure: ");
                trainNumber = Console.ReadLine();
                DateTime time = string.IsNullOrEmpty(trainNumber) ? DateTime.Now : DateTime.Parse(trainNumber);

                trains[i] = new Train(point, number, time);
            }
        }
        public static void Show(Train[] trains)
        {

            for (int i = 0; i < trains.Length; i++)

            {
                Console.Write($"\nTrain {trains[i].NumberTrain} departs to {trains[i].Point} at {trains[i].Time}. ");
            }

        }
    }
}
