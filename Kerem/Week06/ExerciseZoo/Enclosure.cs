using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06.ExerciseZoo
{
    internal class Enclosure
    {

        private string _Description;
        private string _Name;
        private string _Climate;
        private bool _IsFed;
        private List<Animals> _AnimalsList;
        
        public string Name { get => _Name; }

        public Enclosure(string name, string description, string climate)
        {
            _Name = name;
            _Description = description;
            _Climate = climate;
            _AnimalsList = new List<Animals>();
            _IsFed = false;
        }
        public string Description { get => _Description; }
        public bool IsFed {  get => _IsFed; }
        
        public void addAnimals(Animals animals)
        {
            _AnimalsList.Add(animals);
        }
        public void PrintZoo()
        {
            Console.WriteLine($"│   ├── {_Name}, {_Description}, {_Climate}");
            Console.WriteLine();

            foreach (Animals animals in _AnimalsList)
            {

                animals.PrintZoo();
            }


        }
        public void GetAnimalStatisticFood(Dictionary<Food, double> dic)
        {
            foreach(Animals animals in _AnimalsList)
            {
                animals.GetAnimalStatistic(dic);
            }
        }

    }
}
