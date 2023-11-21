using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._02GeometrieInterface
{
    internal class GeometrieRunInterface
    {
        public static void Main()
        {
            //Triangle
            GeometryInterface tri = new TriangleInterface(5);

            Console.WriteLine("Circumfence of triangle: {0:0.0} m", tri.getCircumference());
            Console.WriteLine("Area of triangle: {0:0.0} m^2", tri.getArea());
            Console.WriteLine();
            //circle

            CircleInterface cir = new(5);
            Console.WriteLine("Circumfence of circle: {0:0.0} m", cir.getCircumference());
            Console.WriteLine("Area of circle: {0:0.0} m^2", cir.getArea());
            Console.WriteLine();

            //rectangle
            RectangleInterface rec = new(5, 3);
            Console.WriteLine("Circumfence of rectangle: {0} m", rec.getCircumference());
            Console.WriteLine("Area of rectangle: {0} m^2", rec.getArea());
            Console.WriteLine();

            //square
            SquareInterface squ = new(5);
            Console.WriteLine("Circumfence of square: {0} m", squ.getCircumference());
            Console.WriteLine("Area of square: {0} m^2", squ.getArea());
            Console.WriteLine();

            List<GeometryInterface> geometries = new List<GeometryInterface>();
            geometries.Add(tri);
            geometries.Add(cir);
            geometries.Add(rec);
            geometries.Add(squ);
            double areaAll = 0;
            double circumferenceAll = 0;
            foreach (GeometryInterface geo in geometries)
            {

                circumferenceAll += geo.getCircumference();
                areaAll += geo.getArea();
            }

            Console.WriteLine("Area of all: {0:0.0} m^2", areaAll);
            Console.WriteLine("Circumference of all: {0:0.0} m", circumferenceAll);
        }

    }
}
