using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me the product version key (Pro or Expert): ");
            string key = Console.ReadLine();

            DocumentWorker doc = null;

            switch (key)
            {
                case "pro":
                    doc = new ProDocumentWorker();
                    break;
                case "expert":
                    doc = new ExpertDocumentWorker();
                    break;
                default:
                    Console.WriteLine("The key is wrong. ");
                    doc = new DocumentWorker();
                    break;
            }
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

        }
    }
}
