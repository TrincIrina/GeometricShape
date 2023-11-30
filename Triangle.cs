using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    // Класс Треугольник - наследник класса Геометрические фигуры
    internal class Triangle : GeometricShape, IPrintable
    {
        // Стороны треугольника
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        // Конструкторы
        public Triangle(string name, double a, double b, double c)
            : base(name)
        {
            A = a;
            B = b;
            C = c;
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double Perimeter()
        {
            return A + B + C;
        }
        public override double Square()
        {
            double p = Perimeter();
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return $"Triangle - {Name}, a = {A}, b = {B}, c = {C}";
        }

    }
}
