using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week10
{
    public class Land
    {
        private string _name;
        private string _code;
        private string _capital;
        private string _province;
        private int _area;
        private int _population;

        public Land(string name, string code, string capital, string province, int area, int population) 
        { 
            this._name = name;
            this._code = code;
            this._capital = capital;
            this._province = province;
            this._area = area;
            this._population = population;

        }



    }
}
