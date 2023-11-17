using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week07.Zoo
{
    internal class Enclosure
    {
        private string _Description;
        private string _Climate;
        private string _Name;
        private List<Animals> _AnimalsList;
        private List<ZooKeeper> _ZookeeperList;



        public Enclosure(string Description, string Climate, string Name)
        {
            _Description = Description;
            _Climate = Climate;
            _Name = Name;
            _AnimalsList = new List<Animals>();
            _ZookeeperList = new List<ZooKeeper>();


        }

        public void AddZookeeper(ZooKeeper zk)
        {
            _ZookeeperList.Add(zk);
        }


        public void AddAnimals(Animals animals)
        {
            if (!_AnimalsList.Contains(animals))
            {
                _AnimalsList.Add(animals);
            }
        }



        public void PrintZoo()
        {
            Console.WriteLine($"  |--- Enclosure: {_Name}, {_Description}, {_Climate}");


            foreach (Animals animals in _AnimalsList)
            {
                animals.PrintZoo();
            }
            foreach (ZooKeeper zooKeeper in _ZookeeperList)
            {
                zooKeeper.PrintZooKeeper();
            }


        }
        public void CareAnimals()
        {
            foreach (Animals animals in _AnimalsList)
            {
                if (animals.Hungry)
                {
                    animals.Hungry = false;
                    Console.WriteLine($"{animals.Name} , gerade gefüttert");


                }


            }


        }

        public void AnimalsObserve()
        {
            // Wenn die Liste leer ist, gib nichts aus.
            if (_AnimalsList.Count == 0)
            {
                return;
            }

            // Wähle ein zufälliges Tier aus der Liste.
            int randomIndex = new Random().Next(_AnimalsList.Count);
            Animals animals = _AnimalsList[randomIndex];

            // Gib das Tier aus.
            Console.WriteLine($"Saw {animals.Name}");

        }

        //foreach (Animals animals in _AnimalsList)
        //{
        //   if (animals._Saw) 
        //    {
        //        animals._Saw = false;
        //        Console.WriteLine($"{animals.Name}, lange überwacht");*

        //    }
        //}
    }

}

