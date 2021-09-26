using System;
using System.Text;

namespace Lab2Work4
{
    class Point
    {
        public int X { get; }
        public int Y { get; } 
        public string Name { get; }
        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
    class Figure
    {
        public static int input;
        public Point[] points { get; }
        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }
        public double LengthSize(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }
        public void PerimeterCalculator()
        {
            double Perimeter = 0;
            for (int i = 0; i < input ; i++)
            {
                if (i == points.Length - 1)
                {
                    Perimeter += LengthSize(points[i], points[0]);
                }
                else
                {
                    Perimeter += LengthSize(points[i], points[i + 1]);
                }
            }
            Console.WriteLine("Периметр фігури: " + Perimeter);
        }
        public void FigureInitialization()
        {
            Console.WriteLine("Введіть кількість кутів( від 3 до 5 ): ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input < 3 || input > 5)
            {
                Console.WriteLine("Помилка при введенні");
                Environment.Exit(-1);
            }
            if (input == 3)
            {
                Console.WriteLine("Фігура: трикутник");
            }
            else if (input == 4)
            {
                Console.WriteLine("Фігура: чотирикутник");
            }
            else if (input == 5)
            {
                Console.WriteLine("Фігура: п'ятикутник");
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
            Figure figure = new Figure(new Point(0, 2, "A"), new Point(0, 0, "B"), new Point(2, 0, "C"), new Point(2, 2, "D"), new Point(1, 1, "E"));
            figure.FigureInitialization();
            figure.PerimeterCalculator();
            Console.ReadLine();
        }
    }
}

        
