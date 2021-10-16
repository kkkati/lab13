using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Коммунальная 4 Г", 400, 357, 30);
            building.Print();
            Console.WriteLine();
            MultiBuilding multiBuilding = new MultiBuilding("Коммунальная 4 Г", 400, 357, 30, 12);
            multiBuilding.Print();

            Console.ReadKey();
        }
        class Building
        {
            private string adres;
            private double length;
            private double width;
            private double height;


            //свойства класса
            public double Length
            {
                set
                {
                    if (value>0)
                    {
                        length = value;
                    }
                    else
                    {
                        Console.WriteLine("Введена отрицательная длина");
                    }
                }
                get
                {
                    return length;
                }
            }
            public double Width
            {
                set
                {
                    if (value > 0)
                    {
                        width = value;
                    }
                    else
                    {
                        Console.WriteLine("Введена отрицательная ширина");
                    }
                }
                get
                {
                    return width;
                }
            }
            public double Height
            {
                set
                {
                    if (value > 0)
                    {
                        height = value;
                    }
                    else
                    {
                        Console.WriteLine("Введена отрицательная высота");
                    }
                }
                get
                {
                    return height;
                }
            }

            //конструктор заполнения свойств
            public Building(string adres, double length, double width, double height)
            {
                this.adres = adres;
                Length = length;
                Width = width;
                Height = height;
            }

            //метод, для вывода информации о здании
            public void Print()
            {
                Console.WriteLine("Адрес здания: {0}", adres);
                Console.WriteLine("Длина здания: {0} м", length);
                Console.WriteLine("Ширина здания: {0} м", width);
                Console.WriteLine("Высота здания: {0} м", height);
            }
        }

        sealed class MultiBuilding:Building
        {
            //Поле и свойство
            private int storey;
            public int Storey
            {
                set
                {
                    if (value > 0)
                    {
                        storey = value;
                    }
                    else
                    {
                        Console.WriteLine("Введена отрицательная длина");
                    }
                }
                get
                {
                    return storey;
                }
            }

            //конструктор
            public MultiBuilding(string adres, double length, double width, double height, int storey)
            : base(adres, length, width, height)
            {
                this.Storey = storey;
            }

            //метод Print
            public void Print()
            {
                base.Print();
                Console.WriteLine("Этажность здания: {0} м", storey);
            }
        }
    }
}
