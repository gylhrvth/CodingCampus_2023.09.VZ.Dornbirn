
namespace Timo.Week07._05_GeometryInterface
{
    public  class Pentagon : Geometry
    {
        private double _Length;
        public double Length { get => _Length; }

        public Pentagon(double length)
        {
            _Length = length;
        }

        public double GetCircumference()
        {
            return 5 * _Length;
        }

        public double GetArea()
        {
            return Math.Pow(_Length, 2) / 4 * Math.Sqrt(25 + 10 * Math.Sqrt(5));
        }
    }
}
