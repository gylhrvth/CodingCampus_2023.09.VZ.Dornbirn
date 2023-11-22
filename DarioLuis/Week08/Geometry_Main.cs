namespace DarioLuis.Week08
{
    public class Geometry_Main
    {
        public static void Start()
        {
            List<Geometry> list = new List<Geometry>();
            list.Add(new Circle(10));
            list.Add(new Square(10));
            list.Add(new Rectangle(10, 5));
            list.Add(new Triangle(7));

            foreach (Geometry item in list)
            {
                Console.WriteLine(item);

                Console.Write("Fläche: ");
                Console.Write(item.getArea());
                Console.WriteLine("m²");

                Console.Write("Länge: ");
                Console.Write(item.getCircumference());
                Console.WriteLine("m");

                Console.WriteLine();
            }

            double sumArea = 0;
            double sumUmfang = 0;

            foreach (Geometry item in list)
            {
                sumArea += item.getArea();
                sumUmfang += item.getCircumference();
            }

            Console.Write("Fläche von allen geometrischen Objekten= ");
            Console.Write(sumArea);
            Console.WriteLine("m²");

            Console.Write("Umfang von allen geometrischen Objekten= ");
            Console.Write(sumUmfang);
            Console.WriteLine("m");
        }
    }
}

