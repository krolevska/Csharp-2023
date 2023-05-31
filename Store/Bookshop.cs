using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public class BookShop
    {
        public List<Book> books { get; set; } = new List<Book>();
        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }

        public BookShop(TimeSpan openingTime, TimeSpan closingTime)
        {
            OpeningTime = openingTime;
            ClosingTime = closingTime;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book SellBook(string bookName, TimeSpan currentTime)
        {
            if (currentTime < OpeningTime || currentTime > ClosingTime)
            {
                throw new ShopIsClosedException("Зараз книгарня не працює.");
            }

            var book = books.FirstOrDefault(p => p.Name == bookName);
            if (book == null)
            {
                throw new OutOfStockException("У нас зараз немає цієї книги.");
            }

            books.Remove(book);
            return book;
        }
    }
}