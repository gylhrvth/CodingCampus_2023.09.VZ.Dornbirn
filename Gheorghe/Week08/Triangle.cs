using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week08
{
    internal class Triangle:Geometry
    {
        private double _base;
        private double _height;

        public Triangle(double baseLength, double height)
        {
            _base = baseLength;
            _height = height;
        }

        public virtual double getArea()
        {
            return 0.5 * _base * _height;
        }

        public virtual double GetCircumference()
        {
            return _base + Math.Sqrt(_base * _base + _height * _height);
        }
    }
}

    

