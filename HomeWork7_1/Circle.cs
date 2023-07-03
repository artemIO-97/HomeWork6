using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_1
{
    internal class Circle:Figure
    {
        public double radius { get; set; }
        private double pi = 3.14;
        private double squareCircle;

        public override double GetSquare()
        {
            
            return  Math.Pow(radius, 2) * pi;
            
        }
    }
}
