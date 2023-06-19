using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public class BookShop
    { 

    public List<Book> Books { get; } = new List<Book>();
    public TimeSpan OpeningTime { get; }
    public TimeSpan ClosingTime { get; }
    public List<string> SaleBooks { get; } = new List<string>(); // Додано поле для книг у розпродажі

    public BookShop(TimeSpan openingTime, TimeSpan closingTime)
    {
        OpeningTime = openingTime;
        ClosingTime = closingTime;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
        if (book.IsOnSale)
        {
            SaleBooks.Add(book.Name);
        }
        
    }

        public void SetSaleBooks(List<string> saleBooks)
    {
        SaleBooks.Clear();
        SaleBooks.AddRange(saleBooks);
    }

    public Book SellBook(string bookName, TimeSpan currentTime)
    {
        if (currentTime < OpeningTime || currentTime > ClosingTime)
        {
            throw new ShopIsClosedException("Зараз книгарня не працює.");
        }

        var book = Books.FirstOrDefault(p => p.Name == bookName);
        if (book == null)
        {
            throw new OutOfStockException("У нас зараз немає цієї книги.");
        }

        Books.Remove(book);
        return book;
    }

    public bool IsOnSale(string bookName)
    {
        return SaleBooks.Contains(bookName);
    }
}
}
