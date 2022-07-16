using System;

namespace Classes
{
    class Invoice
    {
        public int account;
        readonly string customer, provider;
        string article;
        int quantity;

        public Invoice(string customer, string provider)
        {
            this.customer = customer;
            this.provider = provider;
        }

        public void VAT(string article, int quantity)
        {
            double VAT = 1.20F;
            Console.WriteLine($"The total sum for {article} for {customer}, account # {account}, from {provider} is {quantity * VAT}.");
        }
    }
}