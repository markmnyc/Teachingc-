using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasOfThings.Models
{
    public class Circle : Shape
    {
        public string Colour { get; set; }

        public Circle(double r) : base(r,0)
        {
                
        }

        public override double Area()
        {
            return PI * x * x;
        }

        public void GrowCircle(double factor)
        {
            x = x * factor;
        }
    }
}
