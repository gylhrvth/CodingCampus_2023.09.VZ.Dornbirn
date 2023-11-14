using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Simon.Week06.Zoo3
{
    internal class AnimalDoctor
    {
        private string _Name;
        private List<Animals> _AnimalsList;


        public AnimalDoctor(string name)
        {
            _Name = name;
            _AnimalsList = new();
        }
        public void PrintAnimalDocotor()
        {
            Console.WriteLine("│\t\t├── {0}", _Name);
        }

        //public double CalcLowestHP()
        //{
        //    double lowesthp = 100;
        //    for (int i = 0; i < _AnimalsList.Count; i++)
        //    {
        //        double percentHP = (_AnimalsList[i].Health / _AnimalsList[i].MaxHealth) * 100;
        //        if (lowesthp > percentHP)
        //        {
        //            lowesthp = percentHP;
        //        }
        //    }
        //    return lowesthp;
        //}

        public void  RestoreHP()
        {
            for(int i = 0; i < _AnimalsList.Count;i++)
            {
                if(Zoo.CalcLowestHP.convertoint == (_AnimalsList[i].Health / _AnimalsList[i].MaxHealth) * 100)
                {

                }
            }


        }

    }
}
