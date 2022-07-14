using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Author: ");
            string a = Console.ReadLine();
            Console.Write("Book: ");
            string b = Console.ReadLine();
            Console.Write("Content: ");
            string c = Console.ReadLine();

            Author author = new Author();
            author.AuthorName = a;
            author.Show();
            Book book = new Book();
            book.BookName = b;
            book.Show();
            Content content = new Content();
            content.Inhalt = c;
            content.Show();

        }
    }
}