using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrick.Week06.Zoo;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Patrick.Week06.Zoo
{
    internal class Enclosure
    {
        private string _Name;

        private string _Temp;

        private bool _WasKeeperInEnclosure;

        private List<Animals> _AnimalsList { get; set; }


        public string Name
        {
            get => _Name;
        }

        //Konstruktor 
        public Enclosure(string name, string temp)
        {
            _Name = name;
            _AnimalsList = new List<Animals>();
            _Temp = temp;
        }

        public List<Animals> AnimalsList
        {
            get => _AnimalsList;

        }

        public void GetEnclosureStatistic(Dictionary<Food, float> dic)
        {
            foreach (Animals animal in _AnimalsList)
            {
                animal.GetAnimalStatistic(dic);
            }
        }

        public void PrintAnimals()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"│      ├── Gehege: {_Name} || Temperatur: {_Temp}");
            Console.ResetColor();
            foreach (Animals animal in _AnimalsList)
            {
                Console.WriteLine($"│          ├── {animal.Name}, {animal.Genus}, {animal.Age} || mag: {animal.Food}");
            }
        }

        public void GetAnimalRandom(string keeperName)
        {
            var random = new Random();
            int randomAnimal = random.Next(AnimalsList.Count);

            Console.WriteLine($"Der Pfleger {keeperName} beobachtet das Tier {AnimalsList[randomAnimal]}");
        }

        public void SimulateDayStart()
        {
            _WasKeeperInEnclosure = false;
        }

        public void SimulateTakeCareOfEnclosure(string keeperName)
        {
            if (_WasKeeperInEnclosure == false)
            {
                foreach (Animals animal in AnimalsList)
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
            Animals loveliestAnimal = AnimalsList[1];
            Console.WriteLine($"{keeperName} bewundert eine Weile sein Lieblingstier {loveliestAnimal}");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
