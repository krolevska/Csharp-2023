using System;

namespace Abstract
{
    class Program
    {
        static void Main()
        {
            Document document = new Document("Contract");
            document.Body = "Body of the contract";
            document.Footer = "Footer of the contract";
            document.Show();
        }
    }
}
