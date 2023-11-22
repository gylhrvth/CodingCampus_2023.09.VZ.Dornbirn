using Fabienne.Week01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week07.Erbung
{
    public class Water
    {
        protected string _Name;
        public Water(string name)
        {
            _Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine(_Name);
        }
    }
}
