using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab2Work3
{
    class Book
    {
        public static void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
            return;
        }
    }
    class Title
    {
        public static string MainName;
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Назва книги: " + MainName);
            return;
        }
    }
    class Author
    {
        public static string AuthorName;
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Автор: " + AuthorName);
            return;
        }
    }
    class Content
    {
        public static string ContentDeskription;
        public static void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Зміст книги: " + ContentDeskription);
            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {       
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1251 = Encoding.GetEncoding(1251);
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.InputEncoding = enc1251;
            Console.WriteLine("Введіть назву книги: ");
            Title.MainName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть автора книги: ");
            Author.AuthorName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть зміст книги: ");
            Content.ContentDeskription = Convert.ToString(Console.ReadLine());
            Book.Show();
            Console.ReadLine();
        }
    }
}
