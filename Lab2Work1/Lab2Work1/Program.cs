using System;

namespace Lab2Work1
{
    class Adress
    {
        private int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Індекс не може бути меньшим за 0");
                }
                else
                {
                    index = value;
                }
            }
        }
        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        private int house;
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Номер апартаменту не може бути меньшим за 0");
                }
                else
                {
                    house = value;
                }
            }
        }
        private int apartment;
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Номер апартаменту не може бути меньшим за 0");
                }
                else
                {
                    apartment = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            Adress Example = new Adress();
            Console.WriteLine("Введіть індекс: ");
            Example.Index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть країну: ");
            Example.Country = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть місто: ");
            Example.City = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть вулицю: ");
            Example.Street = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть будинок: ");
            Example.House = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть номер квартири: ");
            Example.Apartment = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine("Індекс: " + Example.Index);
            Console.WriteLine("Країна: " + Example.Country);
            Console.WriteLine("Місто: " + Example.City);
            Console.WriteLine("Вулиця: " + Example.Street);
            Console.WriteLine("Дім: " + Example.House);
            Console.WriteLine("Апартамент: " + Example.Apartment);
            Console.ReadLine();
        }
    }
}