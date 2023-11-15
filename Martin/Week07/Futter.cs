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
        private int _EinheitPreis;


        public Futter(string name, string einheit, int EinheitPreis)
        {
            _Name = name;
            _Einheit = einheit;
            _EinheitPreis = EinheitPreis;
        }



        public string Name { get { return _Name; } }
        public string Einheit { get {  return _Einheit; } }
        public int EinHeitPreis { get { return _EinheitPreis; } }

    }
}
