using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week08
{
    public class Enclosure
    {
        private string _Name;
        private int _SquareMeter;
        private List<Animal> _AnimalList;
        private Keeper _Keeper;
        
        public string EnclosureName { get => _Name; }

        public Enclosure(string name, int squareMeter, Keeper keeper)
        {
            _Name = name;
            _SquareMeter = squareMeter;
            _AnimalList = new List<Animal>();
            _Keeper = keeper;
        }

        public void PrintEnclosure(string prefix)
        {
            Console.WriteLine("{0} Enclosure: {1} / Size: {2} m² / Keeper: {3}", prefix, _Name, _SquareMeter , (_Keeper == null) ? "No Keeper assigned!" : _Keeper.keeperName);

            if (_AnimalList.Count != 0)
            {
                foreach (Animal animal in _AnimalList)
                {
                    animal.PrintAnimal(prefix + "──");
                    animal.PrintAnimalHunger(prefix);
                }
            }
            else
            {
                Console.Write(prefix + "── ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enclosure is empty!");
                Console.ResetColor();
            }
        }

        public void AddAnimals(Animal animal)
        {
            _AnimalList.Add(animal);
        }

        public void FeedAnimals(Zoo zoo)
        {
            foreach (Animal animal in  _AnimalList)
            {
                int FoodToFeed = 100 - animal.hunger;
                animal.food.unit -= FoodToFeed;
                animal.hunger += FoodToFeed;
            }
        }
    }
}


