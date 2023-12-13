using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week10.CountryInput
{
    public class Country
    {
        private string _Name;
        private string _Code;
        private string _Capital;
        private string _Province;
        private double _Area;
        private double _Population;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public string Code
        {
            get => _Code;
            set => _Code = value;
        }

        public string Capital
        {
            get => _Capital;
            set => _Capital = value;
        }
        public string Province
        {
            get => _Province;
            set => _Province = value;
        }

        public double Area
        {
            get => _Area;
            set => _Area = value;
        }

        public double Population
        {
            get => _Population;
            set => _Population = value;
        }

        public Country()
        {
            //Wird für SearchCountry verwendet, erstellt eine neue Country über den reader.
        }

        public Country(string name, string code, string capital, string province, float area, float population)
        {
            this._Name = name;
            this._Code = code;
            this._Capital = capital;
            this._Province = province;
            this._Area = area;
            this._Population = population;
        }
    }
}
