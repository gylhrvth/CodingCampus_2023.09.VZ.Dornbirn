
namespace Fabian.Week07._06_Geometry
{
    public class Square : Rectangle
    {
        private double _Length;

        public Square(double length) : base(length, length)
        {
            _Length = length;
        }
        public override double GetCircumference()
        {
            return 4 * _Length;
        }

        public override double GetArea()
        {
            return Math.Pow(_Length, 2);
        }
    }
}
