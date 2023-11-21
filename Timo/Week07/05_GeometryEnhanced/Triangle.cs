namespace Timo.Week07._05_GeometryEnhanced
{
    public class Triangle : Geometry
    {
        private double _Length;

        public Triangle(double length)
        {
            _Length = length;
        }

        public override double GetCircumference()
        {
            return 3 * _Length;
        }

        public override double GetArea()
        {
            double height = _Length * Math.Pow(_Length, 1/3);
            return _Length * height / 2;
        }
    }
}
