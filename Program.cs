using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShape
{
    internal class Program
    {
        static void TestGeometricShape(GeometricShape shape)
        {
            Console.WriteLine($"Geometric shape: {shape}");
            Console.WriteLine($"S = {shape.Square()}");
            Console.WriteLine($"P = {shape.Perimeter()}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {            
            Parallelogram parallelogram = new Parallelogram("ABCD", 4, 5, 45);
            parallelogram.Print();
            Console.WriteLine(parallelogram.Square());
            Console.WriteLine(parallelogram.Perimeter());
            parallelogram.Draw();
            Console.WriteLine();

            Ellips ellips = new Ellips("O", 5.8, 7.4);
            ellips.Print();
            Console.WriteLine(ellips.Square());
            Console.WriteLine(ellips.Perimeter());
            Console.WriteLine();

            Triangle triangle = new Triangle(4.5, 6.8, 5);
            triangle.Print();
            Console.WriteLine(triangle.Square());
            Console.WriteLine(triangle.Perimeter());
            Console.WriteLine();

            TestGeometricShape(parallelogram);
            TestGeometricShape(ellips);
            TestGeometricShape(triangle);

            CompositeShape shape = new CompositeShape(3);
            shape.SetShape(parallelogram, 0);
            shape.SetShape(triangle, 1);
            shape.SetShape(ellips, 2);
            shape.Print();
            Console.WriteLine($"S = {shape.Square()}");
            Console.WriteLine($"P = {shape.Perimeter()}");
            shape.Draw();
        }
    }
}
