using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Michael.ZooSimulation
{
    internal class Enclosure
    {
        Random rnd = new Random();


        private string _Name;
        private List<Animal> _Animals = new List<Animal> { };


        public Enclosure(string name, List<Animal> animals = null)
        {
            _Name = name;

            if (animals != null)
            {
                _Animals.AddRange(animals);
            }
        }


        public string Name { get => _Name; }


        public List<Animal> Animals { get => _Animals; }


        public void AddAnimal(Animal ani)
        {
            _Animals.Add(ani);

            ani.AddEnclosure(this);
        }


        public bool GetsFed(Carer carer, string prefix)
        {
            bool animalGotFed = false;
            foreach (Animal ani in _Animals)
            {
                animalGotFed = ani.GetsFed(carer, prefix);
            }
            Console.WriteLine();
            return animalGotFed;
        }


        public void AnimalsFight()
        {
            foreach (Animal animal in _Animals)
            {
                if (animal.Alive)
                {
                    int victim = rnd.Next(_Animals.Count);

                    while (_Animals[victim] == animal || !_Animals[victim].Alive)
                    {
                        victim = rnd.Next(_Animals.Count);
                    }

                    animal.Bites(_Animals[victim]);
                }

            }
        }


        public void PrintSelf(string prefix)
        {
            Console.WriteLine($"{prefix}├──Enclosure: {this}");
            foreach (Animal animal in _Animals)
            {
                animal.PrintSelf(prefix + "    ");
            }
        }


        public void GetsCleaned(Veterenarian vet)
        {
            for (int i = _Animals.Count - 1; i >= 0; i--)
            {
                Animal ani = _Animals[i];
                if (!ani.Alive)
                {
                    Console.WriteLine($"The corpse of {ani.Name} the {ani.Species} gets removed.");
                    _Animals.RemoveAt(i);
                }
            }
        }


        public void AddAnimals(List<Animal> ani)
        {
            _Animals.AddRange(ani);

            foreach (Animal animal in ani)
            {
                animal.AddEnclosure(this);
            }
        }


        public override string ToString()
        {
            return $"{_Name}";
        }

    }
}
