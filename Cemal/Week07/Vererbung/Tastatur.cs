using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Ubung
{
    public class Tastatur : Hardware
    {
        private int _size;

        public Tastatur(string name, string color, int size) : base(name, color)
        {
            _size = size;
        }

        public override void PrintMe()
        {
            Console.WriteLine("ich bin eine {0} und bin mehr als ein Hardware!", _name);
        }
    }
}
