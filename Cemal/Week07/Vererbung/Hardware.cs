using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Ubung
{
    public class Hardware
    {
        protected string _name;
        private string _color;

        public Hardware(string name, string color)
        {
            _name = name;
            _color = color;
        }

        public virtual void PrintMe()
        {
            Console.WriteLine(_name);
        }
    }
}
