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
            List<AnimalFood> foodlist = dic.Keys.ToList();
            for (int i = 0; i < dic.Count; i++)
            {
                foodsumm += dic[foodlist[i]] * foodlist[i].PriceperUnit;
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
            List<Animal> availableAnimals = new();


            foreach (Enclosure enclosure in _EnclosureList)
            {
                foreach (Animal animal in enclosure.AnimalsList)
                {
                    if (animal.Alive)
                    {
                        availableAnimals.Add(animal);
                    }
                }
                //move to enclosure
                // geht nicht wegen liste (availableAnimals) bzw würde code nur verkomplizieren?
            }
            foreach (AnimalDoctor animalDoctor in _AnimalDoctorList)
            {
                Animal? lowestanimal = null;
                float healthInPercent = 0;
                foreach (Animal animal in availableAnimals)
                {
                    float currentHealthInPercent = animal.Health / (float)animal.MaxHealth;
                    if (lowestanimal == null || (currentHealthInPercent < healthInPercent))
                    {
                        lowestanimal = animal;
                        healthInPercent = currentHealthInPercent;
                    }
                }
                if (lowestanimal != null)
                {
                    animalDoctor.RestoreHP(lowestanimal);
                    //availableAnimals.Remove(lowestanimal);
                }

            }
        }

        public void FeedEnclosures()
        {
            foreach (Zookeeper zookeeper in _ZookeeperList)
            {
                zookeeper.FeedEnclosures();
            }
        }




    }
}
