
namespace DarioLuis.Zoo_Dario
{
    public class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        private List<Enclosure> _Enclosures;
        private List<Zookeeper> _Zookeepers;
        

        public List<Enclosure> Enclosures
        {
            get => _Enclosures;
            set => _Enclosures = value;
        }

        public List<Zookeeper> Zookeepers
        {
            get => _Zookeepers;
            set => _Zookeepers = value;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public int FoundingYear
        {
            get => _FoundingYear;
            set => _FoundingYear = value;
        }

        public Zoo(string name, int foundingYear)
        {
            _Name = name;
            _FoundingYear = foundingYear;
            _Enclosures = new List<Enclosure>();
            _Zookeepers = new List<Zookeeper>();
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
                foreach (var animalToRemove in animalsToRemove)
                {
                    enclosure.Animals.Remove(animalToRemove);
                }
            }

        }
        public void PrintStructure()
        {
            Console.WriteLine($"├── Zoo: {_Name}, founded: {_FoundingYear}");
            foreach (var zookeeper in _Zookeepers)
            {
                zookeeper.PrintZooKeeper();
            }
        }
        public override string ToString()
        {
            return "Zoo: " + _Name + ", founded: " + _FoundingYear;
        }

    }
}
