
namespace Timo.Week07._05_GeometryEnhanced
{
    public class GeometryMain
    {
        public static void Start()
        {
            Square s1 = new(10.5);
            Square s2 = new(12.7);

            Circle c1 = new(5.3);
            Circle c2 = new(18);

            Pentagon p1 = new(5);
            Pentagon p2 = new(10);

            Rectangle r1 = new(11.6, 18.3);
            Rectangle r2 = new(1.4, 20.7);

            Triangle t1 = new(5);
            Triangle t2 = new(10.7);

            HouseofNicolaus n1 = new(5);
            HouseofNicolaus n2 = new(9.7);

            CompassStar comp1 = new(25.6);
            CompassStar comp2 = new(13.4);

            List<object> list = new()
            {
                s1, s2, c1, c2, p1, p2, r1, r2, t1, t2, n1, n2, comp1, comp2
            };

            double sumCircumference = 0;
            double sumArea = 0;

            foreach( Geometry o in list )
            {
                sumCircumference += o.GetCircumference();
                sumArea += o.GetArea();
            }
            Console.WriteLine("Circumference: {0:N3} cm", sumCircumference);
            Console.WriteLine("Area: {0:N3} cm^2", sumArea);
        }
    }
}
