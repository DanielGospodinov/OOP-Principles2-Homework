using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples2
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Height = radius;
            Width = radius;
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Height * this.Width;
        }
    }
}
