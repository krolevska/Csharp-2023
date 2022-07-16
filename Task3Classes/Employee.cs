using System;

namespace Classes
{
    class Employee
    {
        string name, surname;
        double experience, position, startAmount;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public double Position { get; set; }
        public double Experience { get; set; }

        public double StartAmount { get; set; }
        public void Calculator()
        {
            Console.WriteLine("{0} {1}'s paycheck is {2}", name, surname, Experience * Position * StartAmount);
        }
    }
}