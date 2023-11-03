namespace Fabian.Week06._04Zoo
{
    public class Animal
    {
        private string _Name;
        private string _Species;
        private Food _Food;
        private int _FoodCount;
        private List<Food> _FoodList = new();

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public string Species
        {
            get => _Species;
            set => _Species = value;
        }
        public List<Food> FoodList
        {
            get => _FoodList;
            set => _FoodList = value;
        }
        public Food Food
        {
            get => _Food;
            set => _Food = value;
        }
        public int FoodCount
        {
            get => _FoodCount;
            set => _FoodCount = value;
        }
        public Animal(string name, string species, Food food, int foodCount)
        {
            _Name = name;
            _Species = species;
            _Food = food;
            _FoodCount = foodCount;
            _FoodList = new List<Food>();
        }
        public void PrintAnimal()
        {
            Console.WriteLine($"│\t\t\t├── {_Name}, {_Species}");
            foreach (var food in _FoodList)
            {
                food.PrintFood(_FoodCount);
            }
        }
        public void GetAnimalStatistic(Dictionary<Food, double> dic)
        {
            if (dic.ContainsKey(_Food))
            {
                dic[_Food] += _FoodCount;
            }
            else
            {
                dic[_Food] = _FoodCount;
            }
        }
        public override string ToString()
        {
            return _Name + ", " + _Species;
        }
    }
}
