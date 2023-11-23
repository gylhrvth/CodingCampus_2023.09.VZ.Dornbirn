using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Museum
{
    public class Kunststuecke
    {
        public string _Name;
        public int _Jahr;
        public string _Kuenstler;
        public string _Kunst;
        public Kunststuecke(string name, int jahr, string kuenstler, string kunst)
        {
            _Name = name;
            _Jahr = jahr;
            _Kuenstler = kuenstler;
            _Kunst = kunst;
        }
    }
}
