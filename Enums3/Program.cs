using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Яка позиція у працівника?" +
                "\ntrainee" +
                "\njunior" +
                "\nmiddle" +
                "\nsenior" +
                "\nteamlead" +
                "\nvp" +
                "\nceo" +
                "\n");

            string position = Console.ReadLine();
            Post worker = (Post)Enum.Parse(typeof(Post), position);

            Console.Write("\nСкільки годин відпрацював працівник?");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accountant accountant = new Accountant();
            Console.WriteLine(accountant.AskForBonus(worker,hours));
        }
    }

    class Accountant
    {
        public string AskForBonus(Post worker, int hours)
        {

            if ((int)worker < hours)
            {
                return string.Format("Дайте йому премію! ");
            }
            else
            {
                return string.Format("Цього місяця він не отримає премію. ");
            }    
        }
    }

    enum Post
    {
        trainee = 44,
        junior = 66,
        middle = 88,
        senior = 110,
        teamlead = 132,
        vp = 154,
        ceo = 176
    }
}
