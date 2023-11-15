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
            Console.WriteLine("{0} Enclosure: {1} / Size: {2} m² / responsible employee: ", prefix, _Name, _SquareMeter);

            if (_KeeperList.Count != 0)
            {
                foreach (Keeper keeper in _KeeperList)
                {
                    keeper.PrintKeeper();                    
                }
            }
            else
            {
                Console.Write(prefix + "── ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No keeper was assigned!");
                Console.ResetColor();
            }
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
        public void AddKeeperToEnclosure(Keeper keeper)
        {
            _KeeperList.Add(keeper);
        }
    }
}


