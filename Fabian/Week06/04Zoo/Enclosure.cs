namespace Fabian.Week06._04Zoo
{
    public class Enclosure
    {
        private readonly Random random = new();

        private string _Name;
        private List<Animal> _Animals;
        private bool _IsFed;
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
            get => _IsFed;
            set => _IsFed = value;
        }

        public Enclosure(string name)
        {
            _Name = name;
            _Animals = new List<Animal>();
            _IsFed = false;
        }
        public void Fight(List<Animal> animalsToRemove)
        {
            foreach (var animal in _Animals)
            {
                foreach (var other in _Animals)
                {
                    if (!animal.IsDead && !other.IsDead && other != animal && random.NextDouble() <= 0.4)
                    {
                        Console.WriteLine($"{animal.Name} bit {other.Name} and did {animal.Damage} damage");
                        int newHealth = ((other.Health - animal.Damage) < 0) ? 0 : other.Health - animal.Damage;
                        Console.WriteLine($"{other.Name}'s health went from {other.Health} to {newHealth}");
                        other.Health -= animal.Damage;

                        if (other.Health <= 0)
                        {
                            other.IsDead = true;
                            Console.WriteLine($"{other.Name} died\n");
                            animalsToRemove.Add(other);
                        }
                        else Console.WriteLine();
                    }

                }
            }
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
