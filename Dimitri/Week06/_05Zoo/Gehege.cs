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
        private List<Tier> _Animals;

        public Gehege(string name, List<Tier> tierListe)
        {
            _Name = name;
            _Animals = tierListe;
        }

        public List<Tier> Animals
        {
            get => _Animals;
        }


        public override string ToString()
        {
            return string.Format("│   ├── Gehege: {0}", _Name);
        }

        public void PrintGehege()
        {
            Console.WriteLine("│   ├── Gehege: {0}", _Name);
            if (_Animals.Count != 0)
            {
                foreach (Tier animals in _Animals)
                {
                    animals.PrintTier();
                }
            } else
            {
                Console.WriteLine("│       ├── Gehege ist leer!");
            }
        }

        public static Gehege AddTier(Gehege gehege, Tier tier) 
        {
            gehege.Animals.Add(tier);
            return gehege;
        }

    }
}
