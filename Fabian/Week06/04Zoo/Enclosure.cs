namespace Fabian.Week06._04Zoo
{
    public class Enclosure
    {
        private string _Name;
        private List<Animal> _Animals;
        private bool isFed;
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public List<Animal> Animals
        {
            get => _Animals;
            set => _Animals = value;
        }
        public bool IsFed
        {
            get => isFed;
            set => isFed = value;
        }

        public Enclosure(string name)
        {
            _Name = name;
            _Animals = new List<Animal>();
        }
        public void PrintEnclosure()
        {
            Console.WriteLine($"│\t\t├── Enclosure: {_Name}");
            foreach (var animal in _Animals)
            {
                animal.PrintAnimal();
            }
        }
        public void GetEnclosureStatistic(Dictionary<Food, double> dic)
        {
            foreach (var animal in _Animals)
            {
                animal.GetAnimalStatistic(dic);
            }
        }
        public override string ToString()
        {
            return "Enclosure: " + _Name;
        }
    }
}
