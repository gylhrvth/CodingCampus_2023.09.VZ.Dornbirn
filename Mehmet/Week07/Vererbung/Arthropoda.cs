using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Vererbung
{
    internal class Arthropoda
    {
        protected string _Name;



        public Arthropoda(string name)
        {
            _Name = name;
        }

        public virtual void PrintMe()
        {
            Console.WriteLine(_Name);
        }



    }
}
