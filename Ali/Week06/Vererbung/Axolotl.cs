using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Vererbung
{
    public class Axolotl : TerrariumA
    {
        private int _Age;

        public Axolotl(string name, int age) 
        {
            _Age = age;
        }

    }
}
