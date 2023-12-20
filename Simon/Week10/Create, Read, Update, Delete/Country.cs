using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week10.Create__Read__Update__Delete
{
    public class Country
    {
        private string _Name;
        private string _Code;
        private string _Capital;
        private string _Province;
        private double _Area;
        private double _Population;

        public Country()
        { 
        }

        public Country(string name, string code, string capital, string province, double area, double population)
        {
            _Name = name;
            _Code = code;
            _Capital = capital;
            _Province = province;
            _Area = area;
            _Population = population;
        }

        public string Name 
        { 
            get { return _Name; }
            set { _Name = value; }
        }
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        public string Capital
        {
            get { return _Capital; }
            set { _Capital = value; }
        }
        public string Province
        {
            get { return _Province; }
            set { _Province = value; }
        }
        public double Area
        {
            get { return _Area; }
            set { _Area = value; }
        }
        public double Population
        {
            get { return _Population; }
            set { _Population = value; }
        }
    }
}
