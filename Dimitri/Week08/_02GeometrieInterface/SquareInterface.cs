using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._02GeometrieInterface
{
    internal class SquareInterface : RectangleInterface
    {
        public SquareInterface(double length) : base(length, length)
        {
            _width = _height = length;
        }

    }
}
