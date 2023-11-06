namespace Fabian.Week06._04Zoo
{
    public class Food
    {
        private string _Name;
        private string _Unit;
        private double _PricePerUnit;

        public string Name 
        { 
            get => _Name;
            set => _Name = value;
        }
        public string Unit
        {
            get => _Unit;
            set => _Unit = value;
        }
        public double PricePerUnit
        {
            get => _PricePerUnit;
            set => _PricePerUnit = value;
        }
        public Food(string name, string unit, double pricePerUnit)
        {
            _Name = name;
            _Unit = unit;
            _PricePerUnit = pricePerUnit;
        }
        public void PrintFood(int foodCount)
        {
            Console.WriteLine($"│\t\t\t\t├── {_Name} {foodCount} {_Unit}");
        }        
        public override string ToString()
        {
            return "Food: " + _Name + ", Unit: " + _Unit;
        }
    }
}
