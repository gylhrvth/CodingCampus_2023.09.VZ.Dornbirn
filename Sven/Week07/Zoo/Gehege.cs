namespace Sven.Week07.Zoo.Zoo

{
    internal class Enclosure
    {

        private string _Name;
        private string _Description;
        private string _Climate;
        private List<Animal> _AnimalsList;
        private List<Keeper> _KeeperList;



        public string Name
        {
            get => _Name;
        }

        public List<Animal> Animals
        {
            get => _AnimalsList;
        }

        public string Description
        {
            get => _Description;
        }

        public Enclosure(string description, string climate, string name)
        {
            _Description = description;
            _Climate = climate;
            _Name = name;
            _AnimalsList = new List<Animal>();
            _KeeperList = new List<Keeper>();

        }

        public void AddAnimals(Animal animals)
        {

            if (!_AnimalsList.Contains(animals))
            {

                _AnimalsList.Add(animals);
            }
        }

        public void AddKeeper(Keeper keeper)
        {
            if (!_KeeperList.Contains(keeper))
            {
                _KeeperList.Add(keeper);
            }

        }
        public void GetEnclosureStatistic(Dictionary<Food, double> dic)
        {
            foreach (var animal in _AnimalsList)
            {
                animal.GetAnimalStatistic(dic);
            }

        }



        public void PrintEnclosure()
        {
            Console.WriteLine($"│   ├──  Enclosure: {_Description}, {_Climate}, {_Name}");
            foreach (Animal a in _AnimalsList)
            {
                a.PrintAnimal();
            }
        }

        internal void getEnclosureStatistic(Dictionary<Food, double> dic)
        {
            throw new NotImplementedException();
        }
    }
}
