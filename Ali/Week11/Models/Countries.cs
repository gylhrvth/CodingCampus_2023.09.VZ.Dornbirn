using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week11.Models
{
    public class Countries
    {
        public string name;
        public string code;
        public string capital;
        public string province;
        public double area;
        public double population;


        public Countries()
        {
        }

        public Countries(string name, string code, string capital, string province, double area, double population)
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
