﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jovo.Week06._05Zoo
{
    internal class Zoo
    {
        private string _Name;
        private string _Locality;
        private int _FoundingYear;
        private int _Capacity;
        private List<Enclosure> _EnclosureList;
        private List<Pfleger> _PflegerList;
        private List<ZooDoc> _ZooDocList;

        public Zoo(string name, string locality, int foundingYear, int capacity)
        {
            _Name = name;
            _Locality = locality;
            _FoundingYear = foundingYear;
            _Capacity = capacity;
            _EnclosureList = new List<Enclosure>();
            _PflegerList = new List<Pfleger>();
            _ZooDocList = new List<ZooDoc>();
        }

        public List<ZooDoc> ZooDocList
        {
            get => _ZooDocList;
            set => _ZooDocList = value;
            
        }
        

        public void AddEnclosure(Enclosure enclosure)
        {

            if (!_EnclosureList.Contains(enclosure))
            {
                _EnclosureList.Add(enclosure);
            }
        }

        public void AddKeeper(Pfleger keeper)
        {
            if (!_PflegerList.Contains(keeper))
            {
                _PflegerList.Add(keeper);
            }
        }

        public void PrintZoo()
        {

            Console.WriteLine($"Zoo: {_Name}, Location: {_Locality}, Founding Year: {_FoundingYear}, Capacity Enclosures: {_Capacity} ");

            foreach (Enclosure enclosure in _EnclosureList)
            {
                enclosure.PrintZoo();

            }


        }

        public void PrintZooStatistic()
        {
            Dictionary<Food,double> dic = new Dictionary<Food,double>();
            foreach(var enclosure in _EnclosureList )
            {
                enclosure.GetEnclosureStatistic(dic);
            }
            Console.WriteLine("Food requirements:");
            double cost = 0;
            foreach (Food food in dic.Keys)
            {
                Console.WriteLine($"{food.Name} : {dic[food]} {food.Unit} /cost per Unit: {food.PricePerUnit}Euro ");
                double amount = dic[food];
                double price = food.PricePerUnit * amount;
                cost += price;
            }
            Console.WriteLine("total daily cost for food: {0:N2}Euro", cost);
        }


        public void Simulate()
        {
            foreach(Enclosure enclosure in _EnclosureList )
            {
                enclosure.IsFed = false;
            }


            foreach(Pfleger pfleger in _PflegerList)
            {
                pfleger.Simulate();
                
            }

        }




        public void HealDaily()
        {
            Console.WriteLine("test");
            List<Animals> AnimalsHeal = new();
            foreach (Enclosure enclosure in _EnclosureList)
                foreach (Animals animal in enclosure.AnimalsList)
                    if (!animal.IsDead) AnimalsHeal.Add(animal);

            foreach (var doctor in _ZooDocList)
            {
                if (AnimalsHeal.Count == 0) break;

                Animals min = null;

                foreach (var animal in AnimalsHeal)
                {
                    if (min == null || (animal.Life / animal.MaxLife) < (min.Life / min.MaxLife))
                    {
                        min = animal;
                    }
                }

                if (min != null)
                {
                    doctor.Heal(min);
                    AnimalsHeal.Remove(min);
                }
            }
        }
        public void FightStart()
        {
            List<Animals> animalsToRemove = new();
            foreach (var enclosure in _EnclosureList)
            {
                enclosure.Fight(animalsToRemove);
                foreach (var animal in animalsToRemove)
                {
                    enclosure.AnimalsList.Remove(animal);
                }
            }
        }

     

    }

    

}
