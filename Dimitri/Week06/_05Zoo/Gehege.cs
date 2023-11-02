using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._05Zoo
{
    public class Gehege
    {

        private string _Name;

        //public string Name
        //{
        //    get => _Name;
        //    set => _Name = value;
        //}

        public Gehege(string name)
        {
            _Name = name;
        }


        public override string ToString()
        {
            return string.Format("│   ├── Gehege: {0}", _Name);
        }

        public void PrintGehege()
        {
            Console.WriteLine("│   ├── Gehege: {0}", _Name);
        }

    }
}
