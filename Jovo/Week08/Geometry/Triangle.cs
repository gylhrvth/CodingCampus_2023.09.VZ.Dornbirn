using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week08.Geometry
{
    internal class Triangle : Geometry1
    {


        private double _length;
        public Triangle(double length)
        {
            _length = length;
        }


        public override double GetCircumference()
        {
            return 3 * _length;

        }

        public override double GetArea()
        {


            return _length * _length * Math.Sqrt(3) / 4; 
        }
    }
}
