using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoo3
{
    internal class Zookeeper
    {
        private string _Name;
        private List<Enclosure> _EnclosureList;
        private Animals _FavAnimal;
        private List<Animals> _AnimalsList;

        public Zookeeper(string name, List<Enclosure> enclosureListZookeeper, Animals animal)
        {
            _Name = name;
            _EnclosureList = enclosureListZookeeper;
            _FavAnimal = animal;
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            _EnclosureList.Add(enclosure);
        }

        public void PrintZookeeper()
        {
            Console.WriteLine("│\t├── {0}", _Name);
        }

        public void FeedEnclosures()
        {
            int sad = 50;
            if (_AnimalsList == null) //WIE?
            {
                for (int i = 0; i < _EnclosureList.Count; i++)
                {
                    if (_EnclosureList[i].Wasfed == false)
                    {
                        Console.WriteLine("{0} füttert Tiere in Gehege {1}", _Name, _EnclosureList[i].Name);
                        _EnclosureList[i].Wasfed = true;
                    }
                    else
                    {
                        sad = sad + 50;
                        if (sad > 100)
                        {
                            Console.WriteLine("{0} wurde bereits gefüttert. {1} ist nun wütend und stampft weiter.", _EnclosureList[i].Name, _Name);
                        }
                        else
                        {
                            Console.WriteLine("{0} wurde bereits gefüttert. {1} ist nun Traurig und geht weiter.", _EnclosureList[i].Name, _Name, sad);
                        }
                    }
                }
                if (_FavAnimal.Alive == true)
                {
                    Console.WriteLine("{0} beobachtet nun seinen Liebling {1}", _Name, _FavAnimal.Name);
                }
                else if (_FavAnimal.Alive == false && _FavAnimal.Deadsince < 3)
                {
                    Console.WriteLine("{1} ist leider verstorben {0} trauert um diesen Verlust.", _Name, _FavAnimal.Name);
                    _FavAnimal.Deadsince++;
                }
            }
            else
            {
                Console.WriteLine("Das gehege ist leider leer hier gibt es nichts zu füttern!");
            }
        }



    }
}
