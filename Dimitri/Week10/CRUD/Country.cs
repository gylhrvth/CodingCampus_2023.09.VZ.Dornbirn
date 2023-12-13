using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week10.CRUD
{
    internal class Country
    {
        public string _Name;
        public string _Code;
        public string _Capital;
        public string _Province;
        public double _Area;
        public double _Population;

        public Country(string name, string code, string capital, string province, double area, double population) 
        { 
            _Name = name;
            _Code = code;
            _Capital = capital;
            _Province = province;
            _Area = area;
            _Population = population;
        }
    }
}
