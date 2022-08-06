using System;

// Индексаторы.

namespace ArraysAndIndexers1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Translate from (ua, en, ge): ");
            string langOne = Console.ReadLine();

            Console.Write("Translate from (ua, en, ge): ");
            string langTwo = Console.ReadLine();

            Console.Write("Give me a word, please: ");
            string word = Console.ReadLine();

            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary[word, langTwo]);

            Console.WriteLine("Do you want to look another word? ");
            string answer = Console.ReadLine();

            while (answer == "yes")
            {
                Console.Write("Give me a word, please: ");
                word = Console.ReadLine();
                Console.WriteLine(dictionary[word, langTwo]);
                Console.WriteLine("Do you want to look another word? ");
                answer = Console.ReadLine();
            }

            Console.WriteLine("Do you want to read all words? ");
            answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine(new string('-', 20));

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(dictionary[i]);
                }
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
