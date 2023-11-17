namespace Selina.Week06.Zoo
{
    public class Food
    {
        private string _NameOfFood;
        private string _Unit;
        private double _Price;

        public string Name { get => _NameOfFood; }
        public string Unit { get => _Unit; }
        public double Price { get => _Price; }

        public Food(string name, string unit, double price)
        {
            _NameOfFood = name;
            _Unit = unit;
            _Price = price;
        }

        //wird zu einem String gemacht
        public override string ToString()
        {
            return $"{_NameOfFood}";
        }
    }
}

