using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    internal class Worker
    {
        private string _name;

        public Worker (string name)
        {
            _name = name;
        }

        public void PrintStructure()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|      ├── Pfleger: {0}", _name);
        }
    }

}
