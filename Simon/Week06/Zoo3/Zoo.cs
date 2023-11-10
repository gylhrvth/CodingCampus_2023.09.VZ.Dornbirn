using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoo3
{
    internal class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        private List<Enclosure> _EnclosureList;

        public Zoo(string name, int foundingYear)
        {
            _Name = name;
            _FoundingYear = foundingYear;
            _EnclosureList = new();
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            _EnclosureList.Add(enclosure);
        }

        public void PrintZoo()
        {
            Console.WriteLine("├── Zoo: {0}, gegründet {1}", _Name, _FoundingYear);
            foreach(Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintEnclosure();
            }
        }

        public void GetFoodStatistics()
        {
            Dictionary<AnimalFood, double> dic = new Dictionary<AnimalFood, double>();

            double foodammount = 0;
            double foodsumm = 0;
            foreach(Enclosure enclosure in _EnclosureList)
            {
                enclosure.GetFoodAnimals(dic);
            }
            foreach(AnimalFood animalFood in dic.Keys)
            {
                foodammount += dic[animalFood];
                Console.WriteLine("{0} wird {1} mal benötigt und kostet pro {3} {2}",animalFood.Name, dic[animalFood], animalFood.PriceperUnit, animalFood.Unit);
                foodsumm += dic[animalFood] * animalFood.PriceperUnit;
            }
            Console.WriteLine("Kosten für Futterbedarf pro Tag: {0}", foodsumm);
            


        }

    }


}
