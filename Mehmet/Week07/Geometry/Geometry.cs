using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Mehmet.Week08.Geometry
{
    public abstract class Geometry
    {
        public abstract string getName();
        public abstract double getCircumference();
        public abstract double getArea();
        //public abstract void PrintForm();

    }
}
