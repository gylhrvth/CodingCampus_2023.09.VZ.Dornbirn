using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._01Geometrie
{
    internal class Square : Rectangle
    {
        public Square(double length) : base(length, length)
        {
            _width = length;
            _side = length;
        }

    }
}
