using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mehmet.Week06.ZOO
{
    internal class Food
    {

        private string _Food;
        private int _KG;
        private int _Price;
        private int _TotalPrice;

        public Food(string food, int kg, int preis, int totalprice)
        {
            _Food = food;
            _KG = kg;
            _Price = preis;
            _TotalPrice = totalprice;
        }

        public void PrintStrukture()
        {
            Console.WriteLine("         └──┤ Essen: {0}, Menge: {1}kg , Preis: {2}Euro , Gesammtpreis: {3}Euro",
                _Food,
                _KG,
                _Price,
                _TotalPrice);
        }
    }
}
