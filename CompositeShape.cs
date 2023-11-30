using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    // Класс Составная фигура состоит из массива фигур фиксированной длины
    internal class CompositeShape : GeometricShape, IPrintable, IDrawable
    {
        private GeometricShape[] shapes {  get; set; }
        public CompositeShape(string name, int size)
            : base(name)
        {
            shapes = new GeometricShape[size];
        }
        public CompositeShape(int size) 
            : this(string.Empty, size) { }
        public void SetShape(GeometricShape shape, int index)
        {
            shapes[index] = shape;
        }
        public override double Square()
        {
            // площадь составной фигуры - сумма площадей фигур, из которых она состоит
            double S = 0;
            foreach (GeometricShape shape in shapes)
            {
                if (shape != null)
                {
                    S += shape.Square();
                }
            }
            return S;
        }
        public override double Perimeter()
        {
            // периметр составной фигуры - сумма периметров фигур, из которых она состоит
            double P = 0;
            foreach (GeometricShape shape in shapes)
            {
                if (shape != null)
                {
                    P += shape.Perimeter();
                }
            }
            return P;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Composite figure {Name}\n");
            foreach (GeometricShape shape in shapes)
            {
                if (shape != null)
                {
                    sb.Append(shape).Append("\n");
                }
            }
            return sb.ToString();
        }
        public void Print()
        {
            // необходимо вызвать Print у каждой фигуры            
            foreach (GeometricShape shape in shapes)
            {
                // если фигура имплементатор IPrintable, то напечатать
                if (shape is IPrintable)
                {
                    ((IPrintable)shape).Print();
                }
                // иначе вывести сообщения, что данная фигура не поддерживает нужный интерфейс
                else
                {
                    Console.WriteLine($"фигура {shape} не поддерживает IPrintable");
                }
            }
        }
        public void Draw()
        {
            // необходимо вызвать Draw у каждой фигуры
            foreach (GeometricShape shape in shapes)
            {
                IDrawable drawable = shape as IDrawable;
                // если фигура имплементатор IDrawable, то напечатать
                if (drawable != null)
                {
                    drawable.Draw();
                }
                // иначе вывести сообщения, что данная фигура не поддерживает нужный интерфейс
                else
                {
                    Console.WriteLine($"фигура {shape} не поддерживает IDrawable");
                }
            }
        }
    }
}
