namespace Fabian.Week07._06_GeometryInterface
{
    public class Triangle : Geometry
    {
        private double _Length;

        public Triangle(double length)
        {
            _Length = length;
        }

        public double GetCircumference()
        {
            return 3 * _Length;
        }

        public  double GetArea()
        {
            double height = _Length * Math.Pow(_Length, 1/3);
            return _Length * height / 2;
        }
    }
}
