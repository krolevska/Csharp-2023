using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write down a note: ");
            Book.Notes newNote = new Book.Notes();
            newNote.Text = Console.ReadLine();


        }
        
    }

    class Book
    {
        public class Notes
        {
            string text;
          public string Text
            {
                get { return text;  }
                set
                {
                    if (text != "")
                        text += "\n";
                    text += value;
                }
            }
        }
    }
}
