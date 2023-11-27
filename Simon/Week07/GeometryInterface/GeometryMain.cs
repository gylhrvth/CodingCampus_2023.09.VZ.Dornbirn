﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.GeometryInterface
{
    public class GeometryMain
    {
        public static void Start()
        {
            List<IGeometry> geometries = new();

            geometries.Add(new Square(10.5));
            geometries.Add(new Square(12.7));
            geometries.Add(new Circle(10.5));
            geometries.Add(new Circle(12.7));
            geometries.Add(new Rectangle(11.6, 18.3));
            geometries.Add(new Rectangle(1.4, 20.7));
            geometries.Add(new Triangle(5));
            geometries.Add(new Triangle(10.7));
            geometries.Add(new HvN(3));
            geometries.Add(new HvN(5.6));
            geometries.Add(new Stern(3.16));
            geometries.Add(new Stern(26.8));

            //Square s1 = new(10.5);
            //Square s2 = new(12.7);

            //Circle c1 = new(5.3);
            //Circle c2 = new(18);

            //Rectangle r1 = new(11.6, 18.3);
            //Rectangle r2 = new(1.4, 20.7);

            //Triangle t1 = new(5);
            //Triangle t2 = new(10.7);

            CalcGeometry(geometries);
        }

        public static void CalcGeometry(List<IGeometry> geometries)
        {
            double overallcircumfrence = 0;
            double overallarea = 0;
            foreach (IGeometry geometry in geometries)
            {
                overallcircumfrence += geometry.GetCircumfrence();
            }
            foreach (IGeometry geometry in geometries)
            {
                overallarea += geometry.GetArea();
            }
            Console.WriteLine($"Der Umfang aller Formen begrägt: {overallcircumfrence} sowie die Gesamtfläche beträgt {overallarea}");
        }

    }
}
