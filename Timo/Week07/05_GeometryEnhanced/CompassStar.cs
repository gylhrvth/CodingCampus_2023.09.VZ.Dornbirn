namespace Timo.Week07._05_GeometryEnhanced
{
    public class CompassStar : Geometry
    {
        private double _Length;

        public CompassStar(double length)
        {
            _Length = length;
        }

        public override double GetArea()
        {
            return new Triangle(_Length).GetArea() * 4 + new Square(_Length).GetArea();
        }

        public override double GetCircumference()
        {
            return 8 * _Length;
        }
    }
}
