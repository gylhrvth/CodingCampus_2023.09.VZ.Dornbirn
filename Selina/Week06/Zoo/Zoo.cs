using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week06.Zoo
{
    public class Zoo
    {
        private string _Name;
        private int _Year;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public int Year
        {
            get => _Year;
            set => _Year = value;
        }

        public Zoo(string name, int year)
        {
            this._Year = year;
            this._Name = name;
        }
    }
}
