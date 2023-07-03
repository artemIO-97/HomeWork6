using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_1
{
    internal class Triangle:Figure
    {
        public double otherSide { get; set; }
        public double hight { get; set; }

        public override double GetSquare()
        {

            return 0.5 * (otherSide * hight);
        }
    }
}
