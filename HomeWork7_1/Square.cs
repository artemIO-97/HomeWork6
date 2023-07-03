using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_1
{
    internal class Square:Figure
    {
        public double firstSide { get; set; }
        public double secondSide { get; set; }

        public override double GetSquare()
        {
            return firstSide * secondSide;

        }
    }
}
