using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples2
{
    class Triangle : Shape
    {
        public override double CalculateSurface()
        {
            return ((Height * Width) / 2);
        }
    }
}
