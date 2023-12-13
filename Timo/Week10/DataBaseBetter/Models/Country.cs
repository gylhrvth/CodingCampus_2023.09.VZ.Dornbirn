using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week10.DataBaseBetter.Models
{
    public class Country
    {
        private string _name;
        private string _code;
        private string _capital;
        private string _province;
        private double _area;
        private double _population;

        public string name
        { get => _name; set => _name = value; }
        public string code
        { get => _code; set => _code = value; }
        public string capital
        { get => _capital; set => _capital = value; }
        public string province
        { get => _province; set => _province = value; }
        public double area
        { get => _area; set => _area = value; }
        public double population 
        { get => _population; set => _population = value; }
        
        public Country()
        {
        }

        public Country(string name, string code, string capital, string province, double area, double population)
        {
            this.name = name;
            this.code = code;
            this.capital = capital;
            this.province = province;
            this.area = area;
            this.population = population;
        }
    }
}