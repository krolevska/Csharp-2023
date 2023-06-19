using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ISale sale = new Sale();
            BookShop shop = new BookShop(new TimeSpan(8, 0, 0), new TimeSpan(20, 0, 0));
            List<string> saleBooks = new List<string> { "Кінґ", "Орвелл" };
            shop.SetSaleBooks(saleBooks);
            Customer customer = new Customer(1000, sale);

            // Створюємо нові продукти
            Book book1 = new Book("Кідрук", "Наукова фантастика", 650, false);
            Book book2 = new Book("Кінґ", "Жахи", 500, true);
            Book book3 = new Book("Роулінґ", "Фентезі", 600, false);
            Book book4 = new Book("Толкін", "Фентезі", 700, true);
            Book book5 = new Book("Орвелл", "Антиутопія", 550, false);

            // Додаємо продукти до магазину
            shop.AddBook(book1);
            shop.AddBook(book2);
            shop.AddBook(book3);
            shop.AddBook(book4);
            shop.AddBook(book5);

            // Виводимо список книг без розпродажу
            Console.WriteLine("НАЯВНІ КНИГИ:");
            Console.WriteLine("");
            foreach (var book in shop.Books)
            {
                if (!shop.IsOnSale(book.Name))
                {
                    Console.WriteLine($"Назва: {book.Name}, Жанр: {book.Type}, Вартість: {book.Price}");
                }
            }

            // Виводимо список книг у розпродажі
            Console.WriteLine("");
            Console.WriteLine("РОЗПРОДАЖ:");
            Console.WriteLine("");
            foreach (var book in shop.Books)
            {
                if (shop.IsOnSale(book.Name))
                {
                    Console.WriteLine($"Назва: {book.Name}, Жанр: {book.Type}, Вартість: {book.SalePrice}");
                }
            }

            // Клієнт вибирає книги для покупки
            string chosenBook;
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Введіть назву книги, яку хочете придбати (чи 'exit', щоб закінчити покупки):");
                chosenBook = Console.ReadLine();

                if (chosenBook.ToLower() == "exit")
                {
                    break;
                }

                // Клієнт намагається купити вибрану книгу о 18:00
                try
                {
                    TimeSpan purchaseTime = new TimeSpan(18, 0, 0);
                    customer.BuyBook(shop, chosenBook, purchaseTime);
                    Console.WriteLine("");
                    Console.WriteLine("Вітаємо, ви придбали книгу! Заберіть решту: " + customer.Money);

                }
                catch (ShopIsClosedException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OutOfStockException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InsufficientFundsException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}