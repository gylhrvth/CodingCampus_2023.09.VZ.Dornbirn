using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoo3
{
    internal class Enclosure
    {
        public static Random random = new Random();
        private string _Name;
        private List<Animal> _AnimalsList;
        private bool _Wasfed;

        public string Name
        {
            get { return _Name; }
        }
        public List<Animal> AnimalsList { get { return _AnimalsList; } set { _AnimalsList = value; } }

        public bool Wasfed
        {
            get { return _Wasfed; }
            set { _Wasfed = value; }
        }

        public Enclosure(string name)
        {
            _Name = name;
            _AnimalsList = new List<Animal>();
            _Wasfed = false;
        }



        public void PrintEnclosure()
        {
            Console.WriteLine("│\t├── Gehege: {0}", _Name);
            foreach (Animal animals in _AnimalsList)
            {
                animals.PrintAnimals();
            }
        }

        public void AddAnimals(Animal animals)
        {
            _AnimalsList.Add(animals);
        }

        public void GetFoodAnimals(Dictionary<AnimalFood, double> dic)
        {
            foreach (Animal animals in _AnimalsList)
            {
                animals.GetFoodAnimals(dic);
            }
        }

        public void FightandBite()
        {
            int rand = random.Next(101);

            for (int i = 0; i < _AnimalsList.Count; i++)
            {
                int bittenanimal = random.Next(_AnimalsList.Count);
                if (bittenanimal != i)
                {
                    Animal attacker = _AnimalsList[i];
                    Animal victim = _AnimalsList[bittenanimal];
                    victim.GetsAttackedBy(attacker);
                    if (!victim.Alive)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} hat {1} leider tödlich verwundet", attacker.Name, victim.Name);
                        Console.ResetColor();
                        _AnimalsList.RemoveAt(bittenanimal);
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0} wurde von {1} gebissen und hat nun noch {2}/{3} Leben!", victim.Name, attacker.Name, victim.Health, victim.MaxHealth);
                        Console.ResetColor();
                    }

                    //if (rand < 100 && _AnimalsList.Count > 1)
                    //{
                    //    int bitedmg = _AnimalsList[i].BiteDmg;
                    //    _AnimalsList[bittenanimal].Health = _AnimalsList[bittenanimal].Health - bitedmg;
                    //    if (_AnimalsList[bittenanimal].Health < 0)
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Red;
                    //        Console.WriteLine("{0} hat {1} leider tödlich verwundet", _AnimalsList[i].Name, _AnimalsList[bittenanimal].Name);
                    //        Console.ResetColor();
                    //        _AnimalsList.RemoveAt(bittenanimal);
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("{0} wurde von {1} gebissen und hat nun noch {2} Leben!", _AnimalsList[bittenanimal].Name, _AnimalsList[i].Name, _AnimalsList[bittenanimal].Health);
                    //    }
                    //}
                }
            }
        }
        //public void FillListAnimals()
        //{
        //    foreach (Animals animals in _AnimalsList)
        //    {
        //        _LowestAnimalList.Add(animals);
        //    }
        //}

        //public void FillList()
        //{
        //    foreach (Animals animal in _AnimalsList)
        //    {
        //        if (animal.Alive == true)
        //        {
        //            availableAnimals.Add(animal);
        //        }
        //    }
        //}




    }
}
