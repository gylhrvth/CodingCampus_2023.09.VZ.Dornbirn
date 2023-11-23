using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week09.Geometry
{
    internal class Main
    {
        private static List<Geometry> geoList = new List<Geometry>();
        public static void Start()
        {
            Circle circle1 = new Circle(12.5);
            geoList.Add(circle1);
            Circle circle2 = new Circle(25);
            geoList.Add(circle2);

            Triangle triangle1 = new Triangle(12, 5, 8.5);
            geoList.Add(triangle1);
            Triangle traingle2 = new Triangle(24.8, 5.6, 4);
            geoList.Add(triangle1);

            Rectangle rec1 = new Rectangle(31, 18);
            geoList.Add(rec1);
            Rectangle rec2 = new Rectangle(8, 31);
            geoList.Add(rec2);

            PrintGeoList();
        }

        public static void PrintGeoList()
        {
            double sumCirc = 0;
            double sumArea = 0;

            foreach (Geometry geo in geoList)
            {
                double geoCirc = geo.GetCircumference();
                Console.WriteLine(geoCirc);
                double geoArea = geo.GetArea();
                Console.WriteLine(geoArea);

                sumCirc += geoCirc;
                sumArea += geoArea;
            }
            Console.WriteLine("\nSum of Geos: ");
            Console.WriteLine(Math.Round(sumCirc, 3));
            Console.WriteLine(Math.Round(sumArea, 3));
        }
    }
}
