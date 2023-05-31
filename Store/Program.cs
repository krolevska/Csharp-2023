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
        // Створюємо новий магазин, який відкривається о 8:00 і закривається о 20:00
        BookShop shop = new BookShop(new TimeSpan(8, 0, 0), new TimeSpan(20, 0, 0));

        // Створюємо нові продукти
        Book book1 = new Book("Кідрук", "Наукова фантастика", 650);
        Book book2 = new Book("Кінґ", "Жахи", 500);
        Book book3 = new Book("Роулінґ", "Фентезі", 600);
        Book book4 = new Book("Толкін", "Фентезі", 700);
        Book book5 = new Book("Орвелл", "Антиутопія", 550);

        // Додаємо продукти до магазину
        shop.AddBook(book1);
        shop.AddBook(book2);
        shop.AddBook(book3);
        shop.AddBook(book4);
        shop.AddBook(book5);

        // Створюємо нового клієнта з 1000 грн
        Customer customer = new Customer(1000);

        // Виводимо список книг
        Console.WriteLine("Наявні книги:");
        foreach (var book in shop.books)
        {
            Console.WriteLine($"Назва: {book.Name}, Жанр: {book.Type}, Вартість: {book.Price}");
        }

        // Клієнт вибирає книги для покупки
        string chosenBook;
        while (true)
        {
            Console.WriteLine("Введіть назву книги, яку хочете придбати (чи 'exit', щоб закінчити покупки):");
            chosenBook = Console.ReadLine();

            if (chosenBook.ToLower() == "exit")
            {
                break;
            }

            // Клієнт намагається купити вибрану книгу о 18:00
            try
            {
                customer.BuyBook(shop, chosenBook, new TimeSpan(18, 0, 0));
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
