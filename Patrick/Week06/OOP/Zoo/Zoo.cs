﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patrick.Week06.OOP.Zoo.VeterinarySurgeon;


namespace Patrick.Week06.OOP.Zoo
{
    internal class Zoo
    {
        private string _Name;
        private string _FoundingYear;
        private List<Enclosure> _EnclosureList;
        private List<ZooKeeper> _ZooKeeperList;
        private List<VeterinarySurgeon> _VeterinarySurgeonList;

        //Properties
        public string Name
        {
            get => _Name;
        }

        public string FoundingYear
        {
            get => _FoundingYear;
        }

        //Konstruktor
        public Zoo(string name, string foundingYear)
        {
            _Name = name;
            _FoundingYear = foundingYear;
            _EnclosureList = new List<Enclosure>();
            _ZooKeeperList = new List<ZooKeeper>();
            _VeterinarySurgeonList = new List<VeterinarySurgeon>();

        }

        public void PrintZooStatistic()
        {
            Dictionary<Food, float> dic = new();
            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.GetEnclosureStatistic(dic);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nahrungsbedarf pro Tag:");
            Console.ResetColor();
            float cost = 0;
            foreach (Food food in dic.Keys)
            {
                Console.WriteLine($"{food.Name,-11} : {dic[food],-4} {food.Unit} pro kg: {food.Price} Euro ");
                float amount = dic[food];
                float price = food.Price * amount;
                cost += price;
            }
            Console.WriteLine("=======================================================");
            Console.WriteLine("Gesamtkosten pro Tag: {0:N2}$", cost);
        }

        public void PrintZoo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"├── Zoo: {_Name} || {_FoundingYear}");
            Console.ResetColor();
        }

        public void PrintStructure()
        {
            PrintZoo();
            foreach (VeterinarySurgeon dr in _VeterinarySurgeonList)
            {
                dr.PrintDoctor();
            }
            foreach (ZooKeeper keeper in _ZooKeeperList)
            {
                keeper.PrintZooKeeper();
            }
        }

        public void SimulateDay(int dayNr)
        {
            foreach (Enclosure enc in _EnclosureList)
            {
                enc.SimulateDayStart();
            }

            Console.WriteLine("Simulation Tag {0} startet.", dayNr);
            foreach (ZooKeeper keep in _ZooKeeperList)
            {
                keep.SimulateZookeeperWork();
            }

            foreach (Enclosure enc in _EnclosureList)
            {
                enc.AnimalBitesAnimal();
            }

            foreach (VeterinarySurgeon vs in _VeterinarySurgeonList)
            {
                Animal animalToHeal = GetLowestRelativeHealth();
                Console.WriteLine($"{vs.Name} muss sich um {animalToHeal} kümmern.");
            }

        }

        public void AddEnclosure(Enclosure enc)
        {
            if (!_EnclosureList.Contains(enc))
            {
                _EnclosureList.Add(enc);
            }
        }

        public void AddZookeeper(ZooKeeper zk)
        {
            if (!_ZooKeeperList.Contains(zk))
            {
                _ZooKeeperList.Add(zk);
            }
        }

        public void AddVeterinarySurgeon(VeterinarySurgeon vs)
        {
            if (!_VeterinarySurgeonList.Contains(vs))
            {
                _VeterinarySurgeonList.Add(vs);
            }
        }

        public Animal GetLowestRelativeHealth()
        {
            Animal best = null;
            foreach (Enclosure enc in _EnclosureList)
            {
                best = enc.GetLowestRelativeHealth(best);
            }
            return best;
        }
    }
}
