using System;
using System.Text;

namespace Lab2Work4
{
    class Point
    {
        private static int x;
        private static int y;
        private static string NamePoint;
        public static int g;
        public static int X
        {
            get
            {
                return x;
            }
        }
        public static int Y
        {
            get
            {
                return y;
            }
        }
        public static string name
        {
            get
            {
                return NamePoint;
            }
        }
        public Point(int x, int y, string NamePoint)
        {
            g = x;
        }
    }
    class Figure
    {
        public static void Input()
        {

        }
        public Figure()
        {
            
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
            Point A = new Point(0, 3, "A");
            Point B = new Point(0, 0, "B");
            Point C = new Point(3, 0, "C");
            Point D = new Point(3, 3, "D");
            Point E = new Point(4, 4, "E");
            Figure NewFigure = new Figure();
        }
    }
}

        
