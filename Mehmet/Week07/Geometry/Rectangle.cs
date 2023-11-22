using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mehmet.Week07.Geometry
{
    internal class Rectangle : Geometry
    {
        private double _x;
        private double _y;
        private string _name;

        public Rectangle(string name, double x, double y)
        {
            _name = name;
            _x = x;
            _y = y;
        }

        public override string getName()
        {
            return _name;
        }

        public override double getCircumference()
        {
            return 2 * _x + 2 * _y;
        }

        public override double getArea()
        {
            return _y * _x;
        }
        
        
        

    }
}

