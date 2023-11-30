using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    // Абстрактный класс Геометрическая фигура
    internal abstract class GeometricShape
    {
        // имя фигуры
        public string Name { get; set; }

        // конструкторы
        public GeometricShape()
        {
            Name = string.Empty;
        }
        public GeometricShape(string name)
        {
            Name = name;
        }
        // Абстрактные методы 
        public abstract double Square();     // нахождения площади фигуры 
        public abstract double Perimeter();  // нахождения периметра фигуры
        // Метод вывода         
        public override string ToString()
        {
            return Name;
        }
    }
}
