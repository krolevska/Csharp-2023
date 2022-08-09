using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures1
{
    class Program
    {
        static void Main()
        {
            string model = Console.ReadLine();
            string producer = Console.ReadLine();
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Notebook notebook = new Notebook(model,producer,price);
            notebook.Show();
        }
    }

    struct Notebook
    {
        string model;
        string producer;
        decimal price;

        public Notebook(string model, string producer, decimal price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine($"Model — {model}, producer — {producer}, price — {price}");
        }
    }
}
