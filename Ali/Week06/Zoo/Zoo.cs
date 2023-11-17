﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Zoo
{
    internal class Zoo

    {
        private string _Name;
        private string _Place;
        private int _FoundingYear;
        private int _Capacity;
        private List<Enclosure> _EnclosureList;
        public Zoo(string name, string place, int foundingYear, int capacity)
        {
            _Name = name;
            _Place = place;
            _FoundingYear = foundingYear;
            _Capacity = capacity;
            _EnclosureList = new List<Enclosure>();

        }
        public void AddEnclosure(Enclosure enclosure)
        {

            if (!_EnclosureList.Contains(enclosure))
            {
                _EnclosureList.Add(enclosure);
            }
        }
        public void PrintZoo()
        {

            Console.WriteLine($"├──Zoo: {_Name}, Year: {_FoundingYear}");

            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();

            }


        }
    }

}
