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
        private List<Zookeeper> _ZookeeperList;
        private List<AnimalDoctor> _AnimalDoctorList;



        public Zoo(string name, int foundingYear)
        {
            _Name = name;
            _FoundingYear = foundingYear;
            _EnclosureList = new();
            _ZookeeperList = new();
            _AnimalDoctorList = new();
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            _EnclosureList.Add(enclosure);
        }

        public void AddZookeeper(Zookeeper zookeeper)
        {
            _ZookeeperList.Add(zookeeper);
        }

        public void AddAnimalDoctor(AnimalDoctor animalDoctor)
        {
            _AnimalDoctorList.Add(animalDoctor);
        }

        public void PrintZoo()
        {
            Console.WriteLine("├── Zoo: {0}, gegründet {1}", _Name, _FoundingYear);
            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintEnclosure();
            }
            foreach (Zookeeper zookeeper in _ZookeeperList)
            {
                zookeeper.PrintZookeeper();
            }
            foreach (AnimalDoctor animalDoctor in _AnimalDoctorList)
            {
                animalDoctor.PrintAnimalDocotor();
            }
        }

        public void GetFoodStatistics()
        {
            Dictionary<AnimalFood, double> dic = new Dictionary<AnimalFood, double>();

            double foodammount = 0;
            double foodsumm = 0;
            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.GetFoodAnimals(dic);
            }
            foreach (AnimalFood animalFood in dic.Keys)
            {
                //foodammount += dic[animalFood];
                //Console.WriteLine("{0} wird {1} mal benötigt und kostet pro {3} {2}", animalFood.Name, dic[animalFood], animalFood.PriceperUnit, animalFood.Unit);
                foodsumm += dic[animalFood] * animalFood.PriceperUnit;
            }
            Console.WriteLine("Kosten für Futterbedarf für diesen Tag: {0}€", foodsumm);

        }

        public void PrintFight()
        {
            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.FightandBite();

            }
        }
        public void FoodReset()
        {
            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.Wasfed = false;
            }
        }

        //public void FillListAnimals()
        //{
        //    foreach(Enclosure enclosure in _EnclosureList)
        //    {
        //        enclosure.FillListAnimals();
        //    }
        //}

        public void RestoreHP()
        {
            List<Animals> availableAnimals = new();
            foreach (Enclosure enclosure in _EnclosureList)
            {
                foreach (Animals animal in enclosure.AnimalsList)
                {
                    if (animal.Alive == true)
                    {
                        availableAnimals.Add(animal);
                    }
                }
                //move to enclosure
            }
            foreach (AnimalDoctor animalDoctor in _AnimalDoctorList)
            {
                Animals lowestanimal = null;
                foreach (Animals animal in availableAnimals)
                {
                    if (lowestanimal == null || (animal.Health / animal.MaxHealth < lowestanimal.Health / animal.MaxHealth))
                    {
                        lowestanimal = animal;
                    }
                }
                if (lowestanimal != null)
                {
                    animalDoctor.RestoreHP(lowestanimal);
                    availableAnimals.Remove(lowestanimal);
                }

            }
        }

        public void FeedEnclosures()
        {
            foreach(Zookeeper zookeeper in _ZookeeperList)
            {
                zookeeper.FeedEnclosures();
            }
        }




    }
}
