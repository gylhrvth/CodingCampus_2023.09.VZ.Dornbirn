using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.LearnDay
{
    internal class Enclosure
    {
        private string _Name;
        private List<Animals> _AnimalList;

        private Random random = new Random();

        private bool _WasKeeperHere;



        public Enclosure(string name)
        {
            _Name = name;
            _AnimalList = new List<Animals>();
        }

        public void PrintAllAnimal()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"│      ├── Gehege: \"{_Name}\" ");
            foreach (Animals animal in _AnimalList)
            {
                animal.PrintAnimal();
            }
        }

        public void FillAnimalList(Animals animal)
        {

            if (!_AnimalList.Contains(animal))
            {
                _AnimalList.Add(animal);
            }
        }

        public void SearchRandomAnimal(string keeperName)
        {
            int randomIndex = random.Next(0, _AnimalList.Count);
            Console.WriteLine($"Der Pfleger \"{keeperName}\" beobachtet das Tier \"{_AnimalList[randomIndex]}\" zufällig.");
        }

        public void GetLovelystAnimal(string keeperName)
        {
            Console.WriteLine($"Der Pfleger \"{keeperName}\" streichelt sein LieblingsTier \"{_AnimalList[1]}\" und hat Spaß dabei!");
        }


        public void WasKeeperHere()
        {
             _WasKeeperHere = false;
        }

        public void KeeperMovingEnclosure(string keeperName)
        {
            if (_WasKeeperHere == false)
            {
                foreach (Animals animal in _AnimalList)
                {
                    Console.WriteLine($"Der Pfleger \"{keeperName}\" geht in das Gehege \"{_Name}\" und füttert das Tier \"{animal}\".");
                }
                _WasKeeperHere = true;
                SearchRandomAnimal(keeperName);
                GetLovelystAnimal(keeperName);
            }

            else
            {
                Console.WriteLine($"Das Gehege \"{_Name}\" wurde heute schon besucht. \"{keeperName}\" kann weiter gehen.");
            }

        }
    }
}
