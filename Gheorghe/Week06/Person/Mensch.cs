using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe
{
    public class Mensch
    {
        private double _Height;
        private int _Year;
        public string Name;
        private double _Weight;


        public Mensch(double height, int year, string name, double weight)
        {
            _Height = height;
            _Year = year;
            Name = name;
            _Weight = weight;

        }



        public override string ToString()
        {
            return String.Format("Name: {0}\nGröße: {1}\nAlter: {2}\nWeight: {3}", Name, _Height, _Year, _Weight);

        }


    }



}
