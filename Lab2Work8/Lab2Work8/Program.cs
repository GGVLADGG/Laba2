using System;
using System.Text;

namespace Lab2Work8
{
    class Invoice
    {
        int account;
        string customer;
        string provider;
        private string article;
        private static int quantity;
        public static double cost;
        public static double price;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public Invoice(string item, int quantity, double price)
        {
            Invoice.quantity = quantity;
            Invoice.price = price;
            Invoice.WithHDC();
            Invoice.WithoutHDC();
        }
        public static void WithHDC()
        {
            cost = quantity * price * 0.8;
            Console.WriteLine("Сума до сплати з НДС товару: " + cost);
        }
        public static void WithoutHDC()
        {
            cost = quantity * price;
            Console.WriteLine("Сума до сплати без урахування НДС товару: " + cost);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = enc1251;
            Console.WriteLine("Що будете замовлювати? ");
            string item = Convert.ToString(Console.ReadLine());
            Console.WriteLine("В якій кількості вам потрібен товар? ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Товар якою ціною ви купуєте? ");
            double price = Convert.ToDouble(Console.ReadLine());
            Invoice PersonInitialization = new Invoice(12345, "Володимир", "Владислав");
            Invoice ItemInitialization = new Invoice(item, quantity, price);
        }
    }
}
