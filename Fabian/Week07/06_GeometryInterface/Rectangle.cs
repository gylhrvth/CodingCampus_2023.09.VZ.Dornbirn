namespace Fabian.Week07._06_GeometryInterface
{
    public class Rectangle : Geometry
    {
        private double _Length;
        private double _Height;  

        public Rectangle(double length, double height)
        {
            _Length = length;
            _Height = height;
        }

        public double GetCircumference()
        {
            return 2 * _Length + 2 * _Height;
        }

        public double GetArea()
        {
            return _Length * _Height;
        }
    }
}
