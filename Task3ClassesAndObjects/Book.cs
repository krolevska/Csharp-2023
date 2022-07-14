using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Book
    {
        string bookName;

        public string BookName
        {
            get { return bookName; }

            set { bookName = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(BookName);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
