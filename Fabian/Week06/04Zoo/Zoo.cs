using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace Fabian.Week06._04Zoo
{
    public class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        private List<Enclosure> _Enclosures;
        private List<ZooKeeper> _ZooKeepers;
        private List<AnimalDoctor> _AnimalDoctors;

        public List<AnimalDoctor> AnimalDoctors
        {
            get => _AnimalDoctors;
            set => _AnimalDoctors = value;
        }
        public List<Enclosure> Enclosures
        {
            get => _Enclosures;
            set => _Enclosures = value;
        }
        public List<ZooKeeper> ZooKeepers
        {
            get => _ZooKeepers;
            set => _ZooKeepers = value;
        }       

        public Zoo(string name, int foundingYear)
        {
            _Name = name;
            _FoundingYear = foundingYear;
            _Enclosures = new List<Enclosure>();
            _ZooKeepers = new List<ZooKeeper>();
            _AnimalDoctors = new List<AnimalDoctor>();
        }
        public void PrintStructure()
        {
            Console.WriteLine($"├── Zoo: {_Name}, founded: {_FoundingYear}");
            foreach (var zookeeper in _ZooKeepers)
            {
                zookeeper.PrintZooKeeper();
            }
        }
        public void PrintZooStatistic()
        {
            Dictionary<Food, double> dic = new();
            foreach (var enclosure in _Enclosures)
            {
                enclosure.GetEnclosureStatistic(dic);
            }
            Console.WriteLine("Food requirements:");
            double cost = 0;
            foreach (Food food in dic.Keys)
            {
                Console.WriteLine($"{food.Name} : {dic[food]} {food.Unit} / per unit: {food.PricePerUnit}$ ");
                double amount = dic[food];
                double price = food.PricePerUnit * amount;
                cost += price;
            }
            Console.WriteLine("total cost for food: {0:N2}$", cost);

        }

        public void FightStart()
        {
            List<Animal> animalsToRemove = new();
            foreach (var enclosure in _Enclosures)
            {
                enclosure.Fight(animalsToRemove);
                foreach (var animal in animalsToRemove)
                {
                    enclosure.Animals.Remove(animal);
                }
            }

        }

        public void HealStart()
        {
            List<Animal> availableAnimals = new();
            foreach (Enclosure enclosure in _Enclosures)
                foreach (Animal animal in enclosure.Animals)
                    if (!animal.IsDead) availableAnimals.Add(animal);
                   
            foreach (var doctor in _AnimalDoctors)
            {
                if (availableAnimals.Count == 0) break;

                Animal min = null;

                foreach (var animal in availableAnimals)
                {
                    if (min == null || (animal.Health / animal.MaxHealth) < (min.Health / min.MaxHealth))
                    {
                        min = animal;
                    }
                }

                if (min != null)
                {
                    doctor.Heal(min);
                    availableAnimals.Remove(min); 
                }
            }
        }

        public override string ToString()
        {
            return "Zoo: " + _Name + ", founded: " + _FoundingYear;
        }
    }
}
