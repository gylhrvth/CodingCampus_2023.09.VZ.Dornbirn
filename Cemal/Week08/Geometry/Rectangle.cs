using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week08.Geometry.Geometry
{
    public class Rectangle : Geometryclass
    {
        private double _Width;
        private double _Height;

        public Rectangle(double width, double height) 
        {
            _Width = width;
            _Height = height;
        }

        public override double getArea()
        {
            return _Width * _Height;
        }

        public override double getCircumference()
        {
           return (_Width * 2) + (_Height * 2);
        }
    }
}
