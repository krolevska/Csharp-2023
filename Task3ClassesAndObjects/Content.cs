using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Content
    {
        string inhalt;

        public string Inhalt
        {
            get
            {
                return inhalt;
            }
            set
            {
                inhalt = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Inhalt);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
