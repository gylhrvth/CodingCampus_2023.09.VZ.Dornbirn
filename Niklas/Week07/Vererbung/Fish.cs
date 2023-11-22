using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Vererbung
{
    public class Fish
    {
        protected string _Name;
        private bool _Eatable;

        public Fish(string name, bool eatable)
        {
            _Name = name;
            _Eatable = eatable;
        }

        public virtual void PrintMe()
        {
            Console.WriteLine(_Name);
        }
    }
}
