<<<<<<< HEAD:Mehmet/ZOO/Doc.cs
﻿using Kerem.Zoo;
using System;
=======
﻿using System;
>>>>>>> cef7d42f6d1ac56725b97fa9b906b80feba585f7:Mehmet/Week06/ZOO/Doc.cs
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD:Mehmet/ZOO/Doc.cs
namespace Kerem.ZOO
=======
namespace Mehmet.Week06.ZOO
>>>>>>> cef7d42f6d1ac56725b97fa9b906b80feba585f7:Mehmet/Week06/ZOO/Doc.cs
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
