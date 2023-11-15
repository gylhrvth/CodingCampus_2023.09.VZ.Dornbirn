using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    internal class Enclosures
    {
        private string _Name;

        public Enclosures(string name)
        {
            _Name = name;
        }

        public void PrintStructure(string prefix)
        {
            Console.WriteLine("|   ├── Gehege: {0}", _Name);
        }
    }
}
