using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mehmet.ZOO
{
    internal class Food
    {

        private string _Food;
        private int _KG;
        private int _Price;

        public Food(string food,int kg,int preis)
        {
            _Food = food;
            _KG = kg;
            _Price = preis;
        }

        public void PrintStrukture()
        {
            Console.WriteLine("         └──┤Essen: {0}, Menge: {1}kg , Preis: {2}Euro",
                _Food,
                _KG,
                _Price);
        }





    }
}
