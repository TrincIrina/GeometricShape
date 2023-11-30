using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    // Класс Эллипс - наследник класса Геометрическая фигура
    internal class Ellips : GeometricShape, IPrintable
    {
        public double MinHalfAxis { get; set; }  // Малая полуось 
        public double MaxHalfAxis { get; set; }  // Большая полуось
        
        // Конструкторы
        public Ellips(string name, double minHalfAxis, double maxHalfAxis)
            : base(name)
        {
            MinHalfAxis = minHalfAxis;
            MaxHalfAxis = maxHalfAxis;
        }
        public Ellips(double minHalfAxis, double maxHalfAxis)
        {
            MinHalfAxis = minHalfAxis;
            MaxHalfAxis = maxHalfAxis;
        }
        // Метод нахождения площади эллипса
        public override double Square()
        {
            return MinHalfAxis * MaxHalfAxis * Math.PI;
        }
        // Метод нахождения длины эллипса
        public override double Perimeter()
        {
            return (MinHalfAxis + MaxHalfAxis) * Math.PI;
        }
        // Метод вывода
        public void Print()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return $"Ellips - {Name}, min-half-axis = {MinHalfAxis}, max-half-axis = {MaxHalfAxis}";
        }
    }
}
