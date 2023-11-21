//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Niklas.Week08.Geometry
//{
//    interface GeometryMainInterface
//    {
//        public static void Start()
//        {
//            getCircumference();
//            Console.WriteLine();
//            getArea();

//        }

//        public static double getCircumference()
//        {
//            List<Triangle> triangles = new List<Triangle>();
//            List<Circle> circles = new List<Circle>();
//            List<Rectangle> rectangles = new List<Rectangle>();

//            triangles.Add(new Triangle(10));
//            triangles.Add(new Triangle(7));
//            circles.Add(new Circle(12));
//            circles.Add(new Circle(4));
//            rectangles.Add(new Rectangle(5, 4));
//            rectangles.Add(new Rectangle(8, 3));
//            rectangles.Add(new Square(5, 5, 5));


//            foreach (Triangle triangle in triangles)
//            {
//                triangle.PrintTriangle();
//            }
//            foreach (Circle circle in circles)
//            {
//                circle.PrintCircle();
//            }
//            foreach (Rectangle rectangle in rectangles)
//            {
//                rectangle.PrintRectangle();
//            }

//            return triangles.Count;
//        }
//        public static double getArea()
//        {
//            List<Triangle> triangles = new List<Triangle>();
//            List<Circle> circles = new List<Circle>();
//            List<Rectangle> rectangles = new List<Rectangle>();

//            triangles.Add(new Triangle(10));
//            triangles.Add(new Triangle(7));
//            circles.Add(new Circle(12));
//            circles.Add(new Circle(4));
//            rectangles.Add(new Rectangle(5, 4));
//            rectangles.Add(new Rectangle(8, 3));
//            rectangles.Add(new Square(5, 5, 5));

//            foreach (Triangle triangle in triangles)
//            {
//                Console.Write($"Triangle area: {((triangle._Lenght *= 2) * Math.Sqrt(3)) / 4:N1}\n");
//            }

//            foreach (Circle circle in circles)
//            {
//                Console.Write($"Circle area: {circle._Radius * 2 * Math.PI:N1}\n");
//            }
//            foreach (Rectangle rectangle in rectangles)
//            {
//                if (rectangle._Height == rectangle._Width)
//                {
//                    Console.WriteLine($"Square area: {rectangle._Height * rectangle._Width:N1}\n");
//                }
//                else if (rectangle._Height != rectangle._Width)
//                {
//                    Console.Write($"Rectangle area: {rectangle._Height * rectangle._Width:N1}\n");
//                }
//            }


//            return triangles.Count;
//        }
//    }
//}
