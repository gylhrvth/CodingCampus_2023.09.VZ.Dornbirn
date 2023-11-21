using System;
using System.Security.Cryptography.X509Certificates;

namespace David.Week06.ZOO
{
    internal class Enclosure
    {
        public Random random = new Random();

        public string _Name { get; private set; }
        public string _Climate { get; private set; }
        private bool _WasKeeperInEnclosure;
        private List<Animals> _AnimalsList;

        //Konstruktor
        public Enclosure(string name, string climate)
        {
            _Name = name;
            _Climate = climate;
            _AnimalsList = new List<Animals>();
        }

        public List<Animals> AnimalsList
        {
            get => _AnimalsList;
        }

        public void GetEnclosureStatistic(Dictionary<Food, float> dict)
        {
            foreach (var animal in _AnimalsList)
            {
                animal.GetAnimalStatistic(dict);
            }
        }

        public void PrintAnimals()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"   ||--> Name: {_Name}, Climate: {_Climate}");
            Console.ResetColor();
            foreach (Animals animals in _AnimalsList)
            {
                Console.WriteLine($"      ||--> Name: {animals.Name}, Age: {animals.Age}, Type: {animals.Genus}, Sex: {animals.Gender}, FoodAmount: {animals.ToString()} ");

            }
        }

        public void SimulateDayStart()
        {
            _WasKeeperInEnclosure = false;
        }

        public void SimulateTakeCareOfEnclosure(string keeperName)
        {
            if (_WasKeeperInEnclosure == false)
            {
                foreach (Animals animal in _AnimalsList)
                {
                    Console.WriteLine($"{keeperName} feeds ANIMAL {animal}, in ENCLOSURE {_Name}, with FOOD {animal.Food}");
                }
                _WasKeeperInEnclosure = true;
                PrintRandomAnimal(keeperName);
                PrintFavoriteAnimal(keeperName);
            }

            else
            {
                Console.WriteLine($"The enclosure {_Name} is already cleand. Name {keeperName} is ready to keep on working in the next enclosure.");
            }

        }

        public void PrintRandomAnimal(string keeperName)
        {
            int randomAnimal = random.Next(AnimalsList.Count);
            Console.WriteLine("The zoo keeper {0} is randomly watching {1}.", keeperName, _AnimalsList[randomAnimal]);

        }

        public void PrintFavoriteAnimal(string keeperName)
        {
            Console.WriteLine("The zoo keeper {0} is watichng his favorite animal {1}", keeperName, _AnimalsList[1]);
        }
    }
}



