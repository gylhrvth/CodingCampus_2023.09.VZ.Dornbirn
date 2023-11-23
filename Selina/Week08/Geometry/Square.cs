
namespace Selina.Week08.Geometry
{
    public class Square : Rectangle
    {
        public double side;
        public string _Name;
        public Square(double side, string name) : base(side, side, name)
        {
            this.side = side;
            this._Name = name;
        }

        public override double GetCircumference()
        {
            return side * 4;
        }
        public override double GetArea()
        {
            return side * side;
        }
        public override string GetName()
        {
            return _Name;
        }
    }
}
