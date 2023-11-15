using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week07.Zoo
{
    public class Enclosure
    {
        private string _Name;
        private string _Climate;
        private string _Description;
        private List<Animals> _Animals;
        public Enclosure(string name, string climate, string desctription)
        {
            _Name = name;
            _Climate = climate;
            _Description = desctription;
            _Animals = new List<Animals>();
        }
        public string Name
        {
            get => _Name;
        }
        public void AddAnimals(Animals animals)
        {
            if (!_Animals.Contains(animals))
            {
                _Animals.Add(animals);
            }
        }
        public void PrintAnimals()
        {
            foreach (Animals animal in _Animals)
            {
                animal.PrintAnimals();
            }
        }
    }
}
