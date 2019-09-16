using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreasOfThings.Models;

namespace AreasOfThings
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 3.0, h = 5.0;
            var circle = new Circle(r);
            var sphere = new Sphere(r);
            var cylinder = new Cylinder(r, h);

            // Display results.
            Console.WriteLine("Area of Circle   = {0:F2}", circle.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", sphere.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", cylinder.Area());
            Console.ReadLine();

            var manyShapes = new List<Shape>
            {
                circle,
                cylinder,
                sphere
            };


            foreach (var shape in manyShapes)
            {
                var definitelyACircle = shape as Circle;
                definitelyACircle?.GrowCircle(2.5);

                Console.WriteLine($"Area of shape = {shape.Area()}");
            }

            Console.ReadLine();

        }
    }
}
