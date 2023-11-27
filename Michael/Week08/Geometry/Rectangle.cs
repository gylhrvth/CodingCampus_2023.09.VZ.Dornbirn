using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.Geometry
{
    internal class Rectangle : Geometry
    {
        private double _Length;
        private double _Width;

        public Rectangle(double Length, double Width)
        {
            _Length = Length;
            _Width = Width;
        }


        public override double GetCircumference()
        {
            return 2 * (_Length + _Width);
        }


        public override double GetArea()
        {
            return _Length * _Width;
        }
    }
}
