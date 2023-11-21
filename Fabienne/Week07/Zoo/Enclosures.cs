using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Fabienne.Week07.Zoo
{
    public class Enclosure
    {
        private string _Name;
        private List<Animal> _Animals;

        public string Name
        {
            get => _Name;
        }
        public Enclosure(string name, string climate, string desctription)
        {
            _Name = name;
            _Animals = new List<Animal>();         
        }
        public void AddAnimals(Animal animals)
        {
            if (!_Animals.Contains(animals))
            {
                _Animals.Add(animals);
            }
        }
        public void PrintAnimals()
        {
            foreach (Animal animal in _Animals)
            {
                animal.PrintAnimals();
            }
        }
        public void ReportFoodRequest(Dictionary<Food, double> report)
        {
            foreach (Animal ani in _Animals)
            {
                ani.ReportFoodRequest(report);
            }
        }
    }
}
