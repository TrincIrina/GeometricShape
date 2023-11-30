using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    // Класс Параллелограм - наследник класса Геометрическая фигура
    internal class Parallelogram : GeometricShape, IPrintable, IDrawable
    {
        // Стороны параллеграма 
        public double A { get; set; }
        public double B { get; set; }
        public double Angle {  get; set; } // Угол между сторонами
        // Конструкторы
        public Parallelogram(string name, double a, double b, double angle)
            : base(name)
        {
            A = a;
            B = b;
            Angle = angle;
        }
        public Parallelogram(double a, double b, double angle)
        {
            A = a;
            B = b;
            Angle = angle;
        }
        // Метод перевода градусы в радианы
        public static double DegreeRadian(double angle)
        {
            return angle * (Math.PI / 180);
        }
        // Метод нахождения площади
        public override double Square()
        {
            if (Angle > 90)
            {
                Angle = 180 - Angle;
            }
            double radian = DegreeRadian(Angle);
            return A * B * Math.Sin(radian);
        }
        // Метод нахождения периметра
        public override double Perimeter()
        {
            return 2 * (A + B);
        }
        // Методы вывода
        public void Print()
        {
            Console.WriteLine(this);
        }
        public void Draw()
        {
            for(int i = 0; i < A; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < B; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int j = 1; j < A - 1; j++)
            {
                for (int i = 0; i < A - 1 - j; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < B; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 0; i < B; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Parallelogram - {Name}, a = {A}, b = {B}, angle = {Angle}";
        }

    }
}
