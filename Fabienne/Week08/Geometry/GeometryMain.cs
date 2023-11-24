using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week08.Geometry
{
    public class GeometryMain
    {
        public static void Start()
        {
            List<Geometry> list = new List<Geometry>();

            list.Add(new Circle(3));
            list.Add(new Triangle(6));
            list.Add(new Rectangle(3, 4));
        }
    }
}
