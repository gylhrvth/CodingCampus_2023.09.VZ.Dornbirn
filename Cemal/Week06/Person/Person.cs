using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week06.NmsPerson
{
    public class Person
    {
        private string _Name;
        private int _Alter;
        private double _Groeße;
        private double _Gewicht;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public int Alter
        {
            get => _Alter;
            set => _Alter = value;
        }

        public double Groeße
        {
            get => _Groeße;
            set => _Groeße = value;
        }

        public double Gewicht
        {
            get => _Gewicht;
            set => _Gewicht = value;
        }

        public Person(string name, int alter, double groeße, double gewicht)
        {
            _Name = name;
            _Alter = alter;
            _Groeße = groeße;
            _Gewicht = gewicht;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAlter: {1}\nGröße: {2} cm\nGewicht: {3} kilo", _Name, _Alter, _Groeße, _Gewicht);
        }
    }
}
