using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
        public class Customer
    {
        public int Money { get; set; }

        public Customer(int money)
        {
            Money = money;
        }

        public void BuyBook(BookShop shop, string bookName, TimeSpan currentTime)
        {
            var book = shop.SellBook(bookName, currentTime);
            if (Money < book.Price)
            {
                throw new InsufficientFundsException("У вас не вистачає коштів, щоб придбати цю книгу.");
            }

            Money -= book.Price;
        }
    }

}
