using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Введи дату народження у форматі 'рррр.мм.дд': ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());

            DateTime now = DateTime.Now;

            DateTime thisBD = new DateTime(now.Year, birthday.Month, birthday.Day);

            TimeSpan wait;

            if (thisBD < now)
            {
                thisBD = new DateTime(now.Year + 1, birthday.Month, birthday.Day);
                wait = thisBD - now;
            }
            else
            {
                wait = thisBD - now;
            }

            Console.Write($"\nДо дня народження залишилося {wait.Days} днів. ");
        }
    }
}
