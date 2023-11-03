using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._05Zoo
{
    public class Zoo
    {
        private string _Zoo;
        private int _Foundation;
        private List<Gehege> _Gehege;

        public List<Gehege> Gehege
        {
            get => _Gehege;
        }

        public Zoo(string zoo, int foundation, List<Gehege> gehege)
        {
            _Zoo = zoo;
            _Foundation = foundation;
            _Gehege = gehege;
        }



        public static Zoo AddGehege(Zoo zoo, Gehege newGehege)
        {

            zoo.Gehege.Add(newGehege);

            return zoo;
        }

        public override string ToString()
        {
            return string.Format("├── Zoo: {0}, gegründet {1}", _Zoo, _Foundation);
        }

        public void PrintZoo()
        {
            Console.WriteLine("├── Zoo: {0}, gegründet {1}", _Zoo, _Foundation);
            if (_Gehege.Count != 0)           
            {
                foreach (Gehege enclosure in _Gehege)
                {
                    enclosure.PrintGehege();
                }
            }  else
            {
                Console.WriteLine("│   ├── Kein Gehege im Zoo!");
            }
        }

    }
}
