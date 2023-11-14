using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class Futter
    {
        private string _Name;
        private string _Einheit;
        private string _Menge;

        public Futter(string name, string einheit, string menge)
        {
            _Name = name;
            _Einheit = einheit;
            _Menge = menge;
        }

    }
}
