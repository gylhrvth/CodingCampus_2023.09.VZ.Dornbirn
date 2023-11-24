using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08.Geometry
{
    internal class Circle : Geometry
    {
        private double _radius;
        private string _name;

        public Circle(string name , double radius)
        {
            _name = name;
            _radius = radius;
        }
        public override string getName()
        {
            return _name;
        }

        public override double getCircumference()
        {            
            return 2 * _radius * 3.14;
        }

        public override double getArea()
        {
            return 3.14 * _radius * _radius;
        }

    }
}
