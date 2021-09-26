using System;
using System.Text;

namespace Lab2Work5
{
    class User
    {
        public static string login;
        public static string name;
        public static string surname;
        public static int age;
        private static string data;
        public User()
        {
            Console.WriteLine("Введіть ваш логін: ");
            User.login = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть ваше ім'я: ");
            User.name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть ваше прізвище: ");
            User.surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть ваш вік: ");
            User.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть дату заповнення анкети: ");
            User.data = Convert.ToString(Console.ReadLine());
        }
        public static void Show()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Логін: " + User.login);
            Console.WriteLine("Ім'я: " + User.name);
            Console.WriteLine("Прізвище: " + User.surname);
            Console.WriteLine("Вік: " + User.age);
            Console.WriteLine("Дата заповнення анкети: " + User.data);
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
            User new_user = new User();
            User.Show();
            Console.ReadLine();
        }
    }
}
