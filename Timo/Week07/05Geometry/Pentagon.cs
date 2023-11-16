using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._05Geometry
{
    public class Pentagon
    {
        private double _Length;

        public Pentagon(double length)
        {
            _Length = length;
        }

        public double Length
        { get => _Length; }
    }
}
