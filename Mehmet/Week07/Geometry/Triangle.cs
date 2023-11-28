using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;

namespace Mehmet.Week08.Geometry
{
    internal class Triangle : Geometry
    {
        private double _x;
        private double _y;
        private double _z;
        private string _name;

        public Triangle(string name , double x, double y, double z)
        {
            _name = name;
            _x = x;
            _y = y;
            _z = z;
        }

        public override string getName()
        {
            return _name;
        }
        public override double getCircumference() 
        {
            return _x + _y + _z;
        }

        public override double getArea()
        {
            double a = (_x + _y + _z)/2;
            return Math.Sqrt(a*(a-_x)*(a-_y)*(a-_z));
        }

    }
}
