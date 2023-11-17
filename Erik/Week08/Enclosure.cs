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
        private List<Keeper> _KeeperList;
        
        public string EnclosureName { get => _Name; }

        public Enclosure(string name, int squareMeter)
        {
            _Name = name;
            _SquareMeter = squareMeter;
            _AnimalList = new List<Animal>();
            _KeeperList = new List<Keeper>();
        }

        public void PrintEnclosure(string prefix)
        {
            Console.WriteLine("{0} Enclosure: {1} / Size: {2} m² Keeper(s): {3}", prefix, _Name, _SquareMeter, string.Join(", ", _KeeperList));

            if (_AnimalList.Count != 0)
            {
                foreach (Animal animal in _AnimalList)
                {
                    animal.PrintAnimal(prefix + "──");
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

        public void AddKeeper(Keeper keeper)
        {
            _KeeperList.Add(keeper);
        }


        public int calculateCost()
        {
            int totalCost = 0;
            foreach(Animal animal in _AnimalList)
            {
                totalCost += animal.returnFoodCost();
            }
            return totalCost;
        }

        public int calculateConsumedFood()
        {
            int totalWeight = 0;
            foreach (Animal animal in _AnimalList)
            {
                totalWeight += animal.returnConsumedFood();
            }
            return totalWeight;
        }

        public bool IsHungry()
        {
            foreach(Animal animal in _AnimalList)
            {
                if (animal.IsHungry == true)
                {
                    return true;
                }                
            }
            return false;
        }

        public void GetsFed(Keeper keeper)
        {
            foreach(Animal animal in _AnimalList )
            {
                animal.IsHungry= false;
                Console.WriteLine($"{animal.AnimalName} gets fed by {keeper.keeperName}!");
            }
        }
    }
}


