using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Vehicle
    {
        readonly int xLocation, yLocation;
        readonly uint price, speed, year;

        public int XLocation { get { return xLocation; } }
        public int YLocation { get { return yLocation; } }
        public uint Price { get { return price; } }
        public uint Speed { get { return speed; } }
        public uint Year { get { return year; } }

        public Vehicle(int xLocation, int yLocation, uint price, uint speed, uint year)
        {
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public Vehicle(uint price, uint speed, uint year)
            : this(0, 0, price, speed, year)
        {

        }
    }

    class Plane : Vehicle
    {
        public Plane(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }

        public Plane(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }

        public int Hight { get; set; }

        private int passengers;
        public int Passengers
        {
            get { return passengers; }
            set
            {
                if (passengers < 0)
                {
                    Console.WriteLine("Cannot be below zero");
                }
                else
                {
                    passengers = value;
                }
            }
        }
    }

    class Car : Vehicle
    {
        public Car(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }

        public Car(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }
    }

    class Ship : Vehicle
    {
        public Ship(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {

        }

        public Ship(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }

        private int passengers;
        public int Passengers
        {
            get { return passengers; }
            set
            {
                if (passengers < 0)
                {
                    Console.WriteLine("Cannot be below zero");
                }
                else
                {
                    passengers = value;
                }
            }
        }

        private string port;
        public string Port
        {
            get
            {
                if (port == null)
                {
                    return "No port setteled";
                }
                else
                {
                    return port;
                }
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Empty");
                }
                else
                {
                    port = value;
                }
            }
        }
    }
}
