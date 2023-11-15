namespace Sven.Week07
{
    internal class Enclosure
    {

        private string _Name;
        private string _Description;
        private string _Climate;
        private List<Animal> _AnimalsList;


        public Enclosure(string description, string climate, string name)
        {
            _Description = description;
            _Climate = climate;
            _Name = name;
            _AnimalsList = new List<Animal>();

        }

        public void AddAnimals(Animal animals)
        {

            if (!_AnimalsList.Contains(animals))
            {

                _AnimalsList.Add(animals);
            }
        }
        public void PrintZoo()
        {
            Console.WriteLine($"│   ├──  Enclosure: {_Description}, {_Climate}, {_Name}");
            foreach (Animal a in _AnimalsList)
            {
                a.PrintZoo();
            }
        }
    }
}
