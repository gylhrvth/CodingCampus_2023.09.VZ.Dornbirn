using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.ZOO
{
    internal class Worker
    {
        private string _Name;
        private string _Workplace;

        public Worker(string name, string workplace)
        {
            _Name = name;
            _Workplace = workplace;
        }

        public void PrintStrukture()
        {
            Console.WriteLine("         └──┤Mitarbeiter: {0},  ArbeitsPlatz: {1}",
                _Name,
                _Workplace);              
        }






    }
}
