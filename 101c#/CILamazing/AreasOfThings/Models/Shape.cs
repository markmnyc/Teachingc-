using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasOfThings.Models
{
    public abstract class Shape
    {
        protected const double PI = Math.PI;
        protected double x, y;

        protected Shape()
        {
        }

        protected Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double Area();
    }
}
