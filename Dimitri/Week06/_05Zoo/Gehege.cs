using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._05Zoo
{
    public class Gehege
    {

        private string _Name;
        private List<Tier> _Tiere;

        public Gehege(string name)
        {
            _Name = name;
            _Tiere = new();
        }

        public List<Tier> Tiere
        {
            get => _Tiere;
        }

        public string Name
        {
            get => _Name;
        }


        public override string ToString()
        {
            return string.Format("{0}", _Name);
        }

        public void PrintGehege()
        {
            Console.WriteLine("│       ├── Gehege: {0}", _Name);
            if (_Tiere.Count != 0)
            {
                foreach (Tier animals in _Tiere)
                {
                    animals.PrintTier();
                }
            } else
            {
                Console.WriteLine("│           ├── Gehege ist leer!");
            }
        }

        public static Gehege AddTier(Gehege gehege, Tier tier) 
        {
            gehege.Tiere.Add(tier);
            return gehege;
        }


        public static List<Tier> GetTiere(Gehege gehege)
        {
            return gehege.Tiere;
        }

        public static string GetName(Gehege gehege)
        {
            return gehege.Name;
        }

    }
}
