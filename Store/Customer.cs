using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    public class Customer
    {
        public int Money { get; private set; }
        private ISale sale;

        public Customer(int money, ISale sale)
        {
            Money = money;
            this.sale = sale;
        }

        public void BuyBook(BookShop shop, string bookName, TimeSpan currentTime)
        {
            var book = shop.SellBook(bookName, currentTime);
            if (Money < book.Price)
            {
                throw new InsufficientFundsException("У вас не вистачає коштів, щоб придбати цю книгу.");
            }

            Money -= book.Price;

            // Виведення інформації про знижку, якщо книга у розпродажі
            if (book.IsOnSale)
            {
                double discountPercentage = 15.0;
                double discountAmount = book.Price * (discountPercentage / 100);
                double discountedPrice = book.Price - discountAmount;
                Console.WriteLine($"Книга '{book.Name}' у розпродажі! Знижка {discountPercentage}%! Вартість зі знижкою: {discountedPrice}");
            }
            else
            {
                Console.WriteLine($"Книга '{book.Name}' придбана! Вартість: {book.Price}");
            }
        }
    }
}
