using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Call
    {
        public static void Main(string[] args)
        {
            string login, name, surname;
            int age;
            DateTime dateTime = DateTime.Now;

            User user = new User(dateTime);
            Console.Write("Login: ");
            user.Login = Console.ReadLine();
            
            Console.Write("Name: ");
            user.Name = Console.ReadLine();
            Console.Write("Surname: ");
            user.Surname= Console.ReadLine();
            Console.Write("Age: ");
            user.Age = Convert.ToInt32(Console.ReadLine());

            user.Call();
            
        }
    }
}
