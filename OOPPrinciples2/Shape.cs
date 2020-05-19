using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples2
{
    public abstract class Shape
    {
        private double height;
        private double width;

        public double Height { get; set; }
        public double Width { get; set; }
        public abstract double CalculateSurface();
    }
}
