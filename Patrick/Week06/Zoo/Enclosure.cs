using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrick.Week06.Zoo;

namespace Patrick.Week06.Zoo
{
    internal class Enclosure
    {
        public string _Name { get; private set; }

        public string _Temp { get; private set; }

        private List<Animals> _AnimalsList { get; set; }


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
            set => _AnimalsList = value;

        }

        public void GetEnclosureStatistic(Dictionary<Food, float> dic)
        {
            foreach (var animal in _AnimalsList)
            {
                animal.GetAnimalStatistic(dic);
            }
        }

        public  void PrintAnimals()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"│      ├── Gehege: {_Name} || Temperatur: {_Temp}");
            Console.ResetColor();
            foreach (Animals animal in _AnimalsList)
            {
                Console.WriteLine($"│          ├── {animal.Name}, {animal.Genus}, {animal.Age} || mag: {animal.ToString()}");
            }           
        }

    }
}
