using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(20000, 20, 2000) { Passengers = 1000, Port = "Odesa" };

            Plane plane = new Plane(2000000, 2000, 1980) { Hight = 5000, Passengers = 200 };

            Car car = new Car(2000, 100, 2010);

            Console.WriteLine("Ship: Price — {0}, Speed — {1}, Year of Production — {2}, Passengers — {3}, Port — {4}. ", ship.Price, ship.Speed, ship.Year, ship.Passengers, ship.Port);
            Console.WriteLine("Plane: Price — {0}, Speed — {1}, Year of Production — {2}, Passengers — {3}, Hight — {4}. ", plane.Price, plane.Speed, plane.Year, plane.Passengers, plane.Hight);
            Console.WriteLine("Car: Price — {0}, Speed — {1}, Year of Production — {2}. ", car.Price, car.Speed, car.Year);

        }
    }
}