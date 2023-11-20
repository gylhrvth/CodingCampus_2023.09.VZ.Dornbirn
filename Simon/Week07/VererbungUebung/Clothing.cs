using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.VererbungUebung
{
    public class Clothing
    {
        protected string _Name;

        public Clothing (string Name)
        {
            _Name = Name;
        }

        public virtual void PrintClothing()
        {
            Console.WriteLine(_Name);
        }



    }
}
