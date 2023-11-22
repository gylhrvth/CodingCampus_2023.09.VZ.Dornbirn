using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week08
{
    public class Rectangle:Geometry
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
            return 2 * _Width + 2 * _Height;
        }
    }
}
