using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] figures =
            {
                new Rectangle(){Width = 3,Height =5},
                new Triangle(){Width = 6,Height = 4},
                new Circle(2.0)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"{figure.ToString().Substring("OOPPrinciples2.".Length)} Surface = {figure.CalculateSurface():F2}");
            }
        }
    }
}
