using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    public class Gehege
    {
        private string _Description;
        private List<Tier> _Tier;

        public Gehege(string description)
        {
            _Description = description;
            _Tier = new List<Tier>();
        }

        public List<Tier> Tier 
        { 
            get { return _Tier; } 
            set { _Tier = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public void PrintGehege()
        {
            Console.WriteLine("│\t├── Gehege: {0}", _Description);
            for (int i = 0; i < _Tier.Count; i++)
            {
                _Tier[i].PrintTier();
            }
        }
    }
}
