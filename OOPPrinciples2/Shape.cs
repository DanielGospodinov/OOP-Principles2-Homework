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

        public Shape(double height,double width)
        {
            this.height = height;
            this.width = width;
        }

        public Shape(double radius)
        {
            this.height = radius;
            this.width = radius;
        }
        public double Height
        {
            set { this.height = value; }
            get { return this.height; }
        }
        public double Width
        {
            set { this.width = value; }
            get { return this.width; }
        }
        public abstract double CalculateSurface();
    }
}
