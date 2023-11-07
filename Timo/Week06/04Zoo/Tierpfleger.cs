using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    public class Tierpfleger
    {
        private string _Name;
        private List<Gehege> _Gehege = new();
        private string _BeobachtTier;



        public Tierpfleger(string name, List<Gehege> zugewieseneGehege)
        {
            _Name = name;
            _Gehege = zugewieseneGehege;
            _BeobachtTier = BeobachtTier;
        }
        public List<Gehege> Gehege
        {
            get => _Gehege;
            set => _Gehege = value;
        }
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public string BeobachtTier
        {
            get => _BeobachtTier;
            set => _BeobachtTier = value;
        }


        public void PrintTierpfleger()
        {
            Console.WriteLine("│\t├── Pfleger: {0}", _Name);
            for (int i = 0; i < _Gehege.Count; i++)
            {
                _Gehege[i].PrintGehege();
            }
        }

        public void Füttern()
        {
            Random random = new Random();
            for (int i = 0; i < _Gehege.Count; i++)
            {
                if (!Gehege[i].Gefüttert)
                {
                    Console.WriteLine("{0} füttert die Tiere im Gehege {1}", _Name, Gehege[i].Description);
                    Gehege[i].Gefüttert = true;
                }
                else
                {
                    Console.WriteLine("Das Gehege {0} wurde bereits gefüttert {1} hat hier nichts mehr zu tun", Gehege[i].Description, _Name);
                }
                int r = random.Next(Gehege.Count - 1);
                BeobachtTier = Gehege[r].Tier[random.Next(Gehege[r].Tier.Count)].Name;
            }
            Console.WriteLine("beobachtet {0}", BeobachtTier);
        }

    }
}
