using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Author
    {
        string authorName;
        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(AuthorName);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
