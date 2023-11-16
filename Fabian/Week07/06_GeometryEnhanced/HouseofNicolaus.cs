
namespace Fabian.Week07._06_GeometryEnhanced
{
    public class HouseofNicolaus : Geometry
    {
        private double _Length;

        public HouseofNicolaus(double length)
        {
            _Length = length;
        }

        public override double GetArea()
        {
            return new Triangle(_Length).GetArea() + new Square(_Length).GetArea();
        }

        public override double GetCircumference()
        {
            return 5 * _Length;
        }
    }
}
