using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._05Geometry
{
    public class Pentagon : Geometry
    {
        private double _Length;
        public double Length { get => _Length; }

        public Pentagon(double length)
        {
            _Length = length;
        }

        public override double GetCircumference()
        {
            return 5 * _Length;
        }

        public override double GetArea()
        {
            return Math.Pow(_Length, 2) / 4 * Math.Sqrt(25 + 10 * Math.Sqrt(5));
        }
    }
}