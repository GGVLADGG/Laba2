using System;
using System.Text;

namespace Lab2Work7
{
    class Employee
    {
        public static string Name;
        public static string Surname;
        public static double age;
        private static string InputNumber;
        public static double OutputOklad;
        public static double OutputNalog;
        public Employee()
        {
            Console.WriteLine("Введіть ваше ім'я: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть вашу фамілію: ");
            Surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть стаж роботи(роки): ");
            age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Оберіть вашу посаду: ");
            Console.WriteLine("Введіть '1' - Junior розробник (20.000)");
            Console.WriteLine("Введіть '2' - Middle розробник (45.000)");
            Console.WriteLine("Введіть '3' - Senior розробник (80.000)");
            InputNumber = Convert.ToString(Console.ReadLine());
            Employee.Calculator();
        }
        public static void Calculator()
        {
            if (InputNumber == "1")
            {
                Console.WriteLine("Ім'я: " + Name);
                Console.WriteLine("Фамілія: " + Surname);
                Console.WriteLine("Посада: Junior розробник");
                OutputNalog = 20000 * 0.2 / age;
                OutputOklad = 20000 - OutputNalog;
                Console.WriteLine("Налог: " + OutputNalog);
                Console.WriteLine("Оклад: " + OutputOklad);
            }
            else if (InputNumber == "2")
            {
                Console.WriteLine("Ім'я: " + Name);
                Console.WriteLine("Фамілія: " + Surname);
                Console.WriteLine("Посада: Middle розробник");
                OutputNalog = 45000 * 0.2 / age;
                OutputOklad = 45000 - OutputNalog;
                Console.WriteLine("Налог: " + OutputNalog);
                Console.WriteLine("Оклад: " + OutputOklad);
            }
            else if (InputNumber == "3")
            {
                Console.WriteLine("Ім'я: " + Name);
                Console.WriteLine("Фамілія: " + Surname);
                Console.WriteLine("Посада: Senior розробник");
                OutputNalog = 80000 * 0.2 / age;
                OutputOklad = 80000 - OutputNalog;
                Console.WriteLine("Налог: " + OutputNalog);
                Console.WriteLine("Оклад: " + OutputOklad);
            }
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
            Employee person = new Employee();
            Console.ReadLine();
        }
    }
}
