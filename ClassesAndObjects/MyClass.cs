using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class MyClass
    {
        public static void Main(string[] args)
        {


            //Создать экземпляр класса Address.
            //В поля экземпляра записать информацию о почтовом адресе.
            //Выведите на экран значения полей, описывающих адрес.

            Address address = new Address();

            Console.Write("Index: ");
            address.Index = Console.ReadLine();

            Console.Write("Country: ");
            address.Country = Console.ReadLine();

            Console.Write("City: ");
            address.City = Console.ReadLine();

            Console.Write("Street: ");
            address.Street = Console.ReadLine();

            Console.Write("House: ");
            address.House = Console.ReadLine();

            Console.Write("Apartment: ");
            address.Apartment = Console.ReadLine();

            Console.WriteLine("Address is: {0}, {1}, {2}, {3} str., {4}, {5} app.", address.Index, address.Country, address.City, address.Street, address.House, address.Apartment);
        }
    }
}
