using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._01Geometrie
{
    internal class GeometrieRun
    {
        public static void Main()
        {
            //Triangle
            Geometry tri = new Triangle(5);

            Console.WriteLine("Circumference of triangle: {0:0.0} m", tri.getCircumference());
            Console.WriteLine("Area of triangle: {0:0.0} m^2", tri.getArea());
            Console.WriteLine();
            //circle

            Circle cir = new(5);
            Console.WriteLine("Circumference of circle: {0:0.0} m", cir.getCircumference());
            Console.WriteLine("Area of circle: {0:0.0} m^2", cir.getArea());
            Console.WriteLine();

            //rectangle
            Rectangle rec = new(5, 3);
            Console.WriteLine("Circumference of rectangle: {0} m", rec.getCircumference());
            Console.WriteLine("Area of rectangle: {0} m^2", rec.getArea());
            Console.WriteLine();

            //square
            Square squ = new(5);
            Console.WriteLine("Circumference of square: {0} m", squ.getCircumference());
            Console.WriteLine("Area of square: {0} m^2", squ.getArea());
            Console.WriteLine();


            //Calculate total circumference and area
            List<Geometry> geometries = new List<Geometry>();
            geometries.Add(tri);
            geometries.Add(cir);
            geometries.Add(rec); 
            geometries.Add(squ);
            double areaAll = 0;
            double circumferenceAll = 0;
            foreach(Geometry geo in geometries)
            {

                circumferenceAll += geo.getCircumference();
                areaAll += geo.getArea();
            }

            Console.WriteLine("Area of all: {0:0.0} m^2", areaAll);
            Console.WriteLine("Circumference of all: {0:0.0} m", circumferenceAll);
        }

    }
}
