using System;

namespace Abstract2
{
    class Program
    {
        static void Main()
        {
            string fileName = Console.ReadLine();

            Redactor redactor = new Redactor();
            redactor.ChooseDocument(fileName);

            redactor.Open();
            redactor.Change();
            redactor.Save();
        }
    }
}
