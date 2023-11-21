using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06._05Zoo
{
    internal class Enclosure
    {
        Random rnd = new Random();

        private string _Description;
        private string _Climate;
        private string _Name;
        private List<Animals> _AnimalsList;
        private bool _IsFed;
        public Enclosure(string description, string climate, string name)
        {
            _Description = description;
            _Climate = climate;
            _Name = name;
            _AnimalsList = new List<Animals>();
           
        }
      
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public bool IsFed
        {
            get => _IsFed;
            set => _IsFed = value;
        }
        public List<Animals> AnimalsList
        {
            get => _AnimalsList;
            
        }
        public string Description
        {
            get => _Description;
            set => _Description = value;
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
            Console.WriteLine($"│   ├── {_Name}, {_Description}, {_Climate}");

            foreach (Animals animals in _AnimalsList)
            {
                animals.PrintZoo();

            }

        }
        public void PrintEnclosure()
        {
            Console.WriteLine($"│\t\t├── Enclosure: {_Name}");
            foreach (var animal in _AnimalsList)
            {
                animal.PrintAnimal();
            }
        }
        public void GetEnclosureStatistic(Dictionary <Food, double> dic)
        {
            foreach ( var animal in _AnimalsList)
            {
                animal.GetAnimalStatistic(dic);
            }

        }


        public override string ToString()
        {
            return "Enclosure22:" + _Name;
        }



        //Pfleger sollte lieblingtier haben
        public void ObserveAnimals(string favspecies)
        {
            int r = rnd.Next(_AnimalsList.Count);
            
            Animals WatchedAnimal = _AnimalsList[r];

            Console.WriteLine(WatchedAnimal.Name + " " + WatchedAnimal.Genus + " wird beobachtet!");

            if(WatchedAnimal.Genus.Equals(favspecies))
            {
                Console.WriteLine( WatchedAnimal.Genus + " is his fav animal so he pets it");
            }

        }

        public Animals GetRandomAnimal()
        {
            int r = rnd.Next(_AnimalsList.Count);

            Animals WatchedAnimal = _AnimalsList[r];

            return WatchedAnimal;

        }

  


        public void Fight(List<Animals> animalsToRemove)
        {
            foreach (var animal in _AnimalsList)
            {
                foreach (var opfer in _AnimalsList)
                {
                    if (!animal.IsDead && !opfer.IsDead && opfer != animal && rnd.NextDouble() <= 0.4)
                    {
                        Console.WriteLine($"{animal.Name} bit {opfer.Name} and did {animal.Bite} damage");
                        int newHealth = ((opfer.Life - animal.Bite) < 0) ? 0 : opfer.Life - animal.Bite;
                        Console.WriteLine($"{opfer.Name}'s health went from {opfer.Life} to {newHealth}");
                        opfer.Life -= animal.Bite;

                        if (opfer.Life <= 0)
                        {
                            opfer.IsDead = true;
                            Console.WriteLine($"{opfer.Name} died\n");
                            animalsToRemove.Add(opfer);
                        }
                        else Console.WriteLine($"{opfer.Name} runs away and is scared\n");
                    }

                }
            }
        }

    }
}
