using System;

namespace Riccardo.Week07.ZooDoppelmayer
{
    public class Enclosure
    {
        private string _Description;
        private string _Climate;
        private string _Name;
        private List<Animals> _AnimalsList;

        public Enclosure(string description, string climate, string name)
        {
            _Description = description;
            _Climate = climate;
            _Name = name;
            _AnimalsList = new List<Animals>();
        }

        public void AddAnimals(Animals animals)
        {

            if (!_AnimalsList.Contains(animals))
            {

                _AnimalsList.Add(animals);
            }
        }



        /*
        private string _Name;
            public string Name { get => _Name; }

            public Enclosure(string name)
            {
                _Name = name;
            }

            public void PrintStructure()
            {
                Console.WriteLine("│   ├── Gehege: {0}",
                    _Name);
            }
        */
    }
}
