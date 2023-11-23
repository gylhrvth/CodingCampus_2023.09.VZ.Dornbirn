
namespace Selina.Week08.Geometry_Interface
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

        public virtual double GetCircumference()
        {
            return side * 4;
        }
        public virtual double GetArea()
        {
            return side * side;
        }
        public virtual string GetName()
        {
            return _Name;
        }
    }
}
