using System;

namespace Lab2work2
{
    class Rectangle
    {
        double side1;
        double side2;
        public Rectangle() { Console.WriteLine("Введіть сторону 'a' прямокутника: "); side1 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("Введіть сторону 'b' прямокутника: "); side2 = Convert.ToDouble(Console.ReadLine()); }
        public double AreaCalculator()
        {
            double res1;
            res1 = side1 * side2;
            return res1;
        }
        public double PerimeterCalculator()
        {
            double res2;
            res2 = (side1 + side2) * 2;
            return res2;
        }
        private double area;
        public double Area
        {
            get
            {
                area = AreaCalculator();
                return area;
            }
        }
        private double perimeter;
        public double Perimeter
        {
            get
            {
                perimeter = PerimeterCalculator();
                return perimeter;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Rectangle Information = new Rectangle();
            Console.WriteLine("Площа прямокутника: " + Information.Area);
            Console.WriteLine("Периметр прямокутника: " + Information.Perimeter);
            Console.ReadLine();
        }
    }
}
