using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoo3
{
    internal class Enclosure
    {
        private string _Name;
        private List<Animals> _AnimalsList;

        public Enclosure(string name)
        {
            _Name = name;
            _AnimalsList = new List<Animals>();
        }

        public void PrintEnclosure()
        {
            Console.WriteLine("│\t├── Gehege: {0}", _Name);
            foreach(Animals animals in _AnimalsList)
            {
                animals.PrintAnimals();
            }
        }

        public void AddAnimals(Animals animals)
        {
            _AnimalsList.Add(animals);
        }

        public void GetFoodAnimals (Dictionary<AnimalFood, double> dic)
        {
            foreach(Animals animals in _AnimalsList)
            {
                animals.GetFoodAnimals(dic);
            }
        }






    }
}
