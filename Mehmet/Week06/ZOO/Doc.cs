using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week06.ZOO
{
    internal class Doc
    {

        private string _Name;
        private List<Cage> _CageList;
        private List<Animal> _AnimalList;
        public Doc(string name)
        {
            _Name = name;
            _CageList = new List<Cage>();
            _AnimalList = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _AnimalList.Add(animal);
        }
        public void AddCage(Cage cage)
        {
            _CageList.Add(cage);
        }

        public void HealAnimal()
        {
            foreach (Cage cage in _CageList)
            {
                cage.HealAnimalinCage();
            }
        }

    }
}
