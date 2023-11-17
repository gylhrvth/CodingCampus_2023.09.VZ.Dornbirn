using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Patrick.Week06.Zoo;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Patrick.Week06.Zoo
{
    internal class Enclosure
    {
        private static Random random = new Random();
        
        private string _Name;

        private string _Temp;

        private bool _WasKeeperInEnclosure;

        private List<Animal> _AnimalsList { get; set; }


        public string Name
        {
            get => _Name;
        }

        //Konstruktor 
        public Enclosure(string name, string temp)
        {
            _Name = name;
            _AnimalsList = new List<Animal>();
            _Temp = temp;
        }


        public void AddAnimal(Animal animal)
        {
            if (!_AnimalsList.Contains(animal)) { 
                _AnimalsList.Add(animal);
            }
        }

        public void GetEnclosureStatistic(Dictionary<Food, float> dic)
        {
            foreach (Animal animal in _AnimalsList)
            {
                animal.GetAnimalStatistic(dic);
            }
        }

        public void PrintAnimals()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"│      ├── Gehege: {_Name} || Temperatur: {_Temp}");
            Console.ResetColor();
            foreach (Animal animal in _AnimalsList)
            {
                animal.PrintAnimal();
            }
        }

        public void GetAnimalRandom(string keeperName)

        {
            Random random = new Random();
            int randomAnimal = random.Next(_AnimalsList.Count);

            Console.WriteLine($"Der Pfleger {keeperName} beobachtet das Tie" +
                $"r {_AnimalsList[randomAnimal]} zufällig.");
        }
         
        public void SimulateDayStart()
        {
            _WasKeeperInEnclosure = false;
        }

        public void SimulateTakeCareOfEnclosure(string keeperName)
        {
            if (_WasKeeperInEnclosure == false)
            {
                foreach (Animal animal in _AnimalsList)
                {
                    Console.WriteLine($"{keeperName} füttert das Tier {animal}, im Gehege {Name}, mit dem Futter {animal.Food} ");
                }
                _WasKeeperInEnclosure = true;
                GetAnimalRandom(keeperName);
                LoveliestAnimalForKeeper(keeperName);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Das Gehege {Name} wurde schon gereinigt. {keeperName} kann weitergehen.");
            }
        }

        public void LoveliestAnimalForKeeper(string keeperName)
        {
            Animal loveliestAnimal = _AnimalsList[1];
            Console.WriteLine($"{keeperName} bewundert eine Weile sein Lieblingstier {loveliestAnimal}.");
        }

        public void AnimalBitesAnimal()
        {            
            foreach (Animal aggressor in _AnimalsList)
            {
                int randomBite = random.Next(0, 101);
                if (randomBite <= 40)
                {
                    int randomAnimal = random.Next(0, _AnimalsList.Count);
                    Animal victom = _AnimalsList[randomAnimal];
                    aggressor.DoBite(victom);                    
                }
            }
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
