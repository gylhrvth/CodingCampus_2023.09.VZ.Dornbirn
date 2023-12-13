using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week11L.Models
{
    internal class Country
    {


        public string Name;
        public string Code;
        public string Province;
        public double Area;
        public double Population;




        public Country(string name, string code, string province, double area, double population)
        {
            this.Name = name;
            this.Code = code;
            this.Province = province;
            this.Area = area;
            this.Population = population;

        }
    }
}
