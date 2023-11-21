using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08.Vererbung
{
    internal class Diseases
    {
        protected string _name;

        public Diseases(string name)
        {
            _name = name;
        }
        public virtual void PrintMe()
        {
            Console.WriteLine(_name);
        }
    }

}
