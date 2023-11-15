namespace Selina.Week06.Zoo
{
    public class Food
    {
        private string _NameOfFood;
        private string _Unit;
        private double _Price;
        public Dictionary<int, int> _FoodPrice;

        public Food(string name, string unit, double price)
        {
            _NameOfFood = name;
            _Unit = unit;
            _Price = price;
            _FoodPrice = new Dictionary<int, int>();
        }
        public void Dictionary(int number1, int number2)
        {
            _FoodPrice.Add(number1, number2);
        }
        public override string ToString()
        {
            return $"{_NameOfFood}";
        }
    }
}

