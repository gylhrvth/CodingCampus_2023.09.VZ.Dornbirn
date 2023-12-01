using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week08.Geometry
{
    internal class GeometryMain
    {
        public static void Start()
        {
            List<Geometry> geometryList = new List<Geometry>();

            geometryList.Add(new Circle("Kreis", 5));
            geometryList.Add(new Rectangle("Rechteck", 4, 3));
            geometryList.Add(new Square("Würfel", 5));
            geometryList.Add(new Triangle("Dreieck", 3, 4, 5));

            foreach (Geometry geometry in geometryList)
            {
                Console.WriteLine(geometry.getName());
                Console.WriteLine("Umfang: " + geometry.getCircumference());
                Console.WriteLine("Flächeninhalt: " + geometry.getArea());
                Console.WriteLine();
            }


           
        }
    }
}
