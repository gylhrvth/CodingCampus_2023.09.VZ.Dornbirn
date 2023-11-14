using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class EnclosureClass
    {
        private string _name;
        private string _type;
        private List<AnimalClass> _animalsList = new List<AnimalClass>();

        public EnclosureClass(string name, string type)
        {
            _name = name;
            _type = type;
            _animalsList = new List<AnimalClass>();
        }
        public void AddAnimal(AnimalClass animal)
        {
            _animalsList.Add(animal);
        }

        public void PrintAnimals()
        {

            foreach (AnimalClass animal in _animalsList)
            {
                Console.WriteLine($"    |-- ---Name:{animal.Name}..Art: {animal.Art}");
            }
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Type
        {
            get => _type;
            set => _type = value;
        }

      
    }
}
