using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._01Geometrie
{
    public abstract class Geometry
    {
        public double _side;

        public Geometry(double side)
        {
            _side = side;
        }
        public abstract double getCircumference();

        public abstract double getArea();
    }
}
