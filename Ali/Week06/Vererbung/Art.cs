using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Vererbung
{
    public class Art
    {
        protected string _Name;
        private int _Age;

        public Art(string name, int age)
        {
            _Name = name;
            _Age = age;
        }

        public virtual void PrintMe()
        {
            Console.WriteLine(_Name);
        }

    }
}
