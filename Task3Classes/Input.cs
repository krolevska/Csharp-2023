using System;

namespace Classes
{
    internal class Input
    {
        public static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Employee employee = new Employee(name, surname);

            Console.Write("Position (Teammate, Lead, Head, VP): ");
            string position = Console.ReadLine();

            string[] positions = { "Teammate", "Lead", "Head", "VP" };

            for (int i = 0; i < positions.Length; i++)
            {
                if (position == positions[i])
                {
                    employee.Position = 1.00D + i * 0.15D;
                }
                else
                {
                    continue;
                }
            }

            Console.Write("Experience: ");
            int experience = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= experience; i++)
            {
                employee.Experience = 1.00D + i * 0.15D;
            }

            Console.Write("Basic salary: ");
            employee.StartAmount = Convert.ToDouble(Console.ReadLine());

            employee.Calculator();
        }

    }
}
