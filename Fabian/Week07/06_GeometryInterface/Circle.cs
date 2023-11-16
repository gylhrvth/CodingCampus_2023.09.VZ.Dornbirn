namespace Fabian.Week07._06_GeometryInterface
{
    public class Circle : Geometry
    {
        private double _Radius;

        public Circle(double length)
        {
            _Radius = length;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * _Radius;
        }

        public double GetArea()
        {
            return Math.Pow(_Radius, 2) * Math.PI;
        }
    }
}
