using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim
{
    public class Enclosure
    {
        private string _Name;
        private string _Descritpion;
        private string _Climate;
        private List<Animals> _AnimalsList;

        public Enclosure(string name, string descritpion, string climate)
        {
            _Descritpion = descritpion;
            _Name = name;
            _Climate = climate;
            _AnimalsList = new List<Animals>();
        }

        public void AddAnimals(Animals animals)
        {
            if (!_AnimalsList.Contains(animals))
            {
                _AnimalsList.Add(animals);
            }
        }

        public void PrintZoo()
        {
            Console.WriteLine("|   ├── Gehege: {0}, {1}, {2}", _Name, _Descritpion, _Climate);

            foreach (Animals animals in _AnimalsList)
            {
                animals.PrintZoo();
            }
        }
    }
}
