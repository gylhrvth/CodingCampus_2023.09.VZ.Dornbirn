﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06.ExerciseZoo
{
    internal class Zoo
    {
        private string _Name;
        private int _Established;
        private List<Enclosure> _EnclosureList;
        private List<Pfleger> _pfleger;

        public List<Enclosure> Enclosurelist
        {
            get => _EnclosureList;
            set => _EnclosureList = value;
        }
        public List<Pfleger> Pfleger
        {
            get => _pfleger;
            set => _pfleger = value;
        }

        public Zoo(string name, int established)
        {
            _Name = name;
            _Established = established;
            _EnclosureList = new List<Enclosure>();
            _pfleger = new List<Pfleger>();
        }
        public void addEnclosure(Enclosure enc)
        {
            _EnclosureList.Add(enc);
        }
        public void AnimalStatistic()
        {
            double gesamtpreis = 0;

            Dictionary<Food, double> dic = new Dictionary<Food, double>();
            foreach (Enclosure enc in _EnclosureList)
            {
                enc.GetAnimalStatisticFood(dic);

            }
            foreach (Food f in dic.Keys)
            {
                gesamtpreis += dic[f] * f.PricePerUnit;

            }

            Console.WriteLine("Kosten pro Tag : " + gesamtpreis);

        }

        public void PrintZoo()
        {
            Console.WriteLine($"├── Zoo: {_Name}, Established {_Established}");

            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();
            }



            Console.WriteLine();
            foreach (Pfleger p in _pfleger)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                p.PrintZooPfleger();
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
