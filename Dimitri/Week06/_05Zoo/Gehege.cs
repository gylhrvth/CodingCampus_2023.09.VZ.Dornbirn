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
        private Random rnd = new Random();

        private string _Name;
        private List<Tier> _Tiere;
        private bool _Gefuettert = false;
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
        public bool Gefuettert
        {
            get => _Gefuettert;
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
            }
            else
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
        public bool GehegeGefuetter()
        {
            return _Gefuettert;
        }
        public void SetGehegeGefuettert(bool gefuettert)
        {
            if (gefuettert)
            {
                _Gefuettert = true;
            }
            else if (!gefuettert)
            {
                _Gefuettert = false;
            }
        }
        public Tier? getRandomAnimalOtherThan(Tier tier)
        {
            if (tier == null)
            {
                return null;
            }
            int j = rnd.Next(_Tiere.Count);
            while (_Tiere[j] == tier)
            {
                j = rnd.Next(_Tiere.Count);
            }
            return _Tiere[j];
        }
        public void Fight()
        {
            List<Tier> animalsToRemove = new List<Tier>();

            if (_Tiere.Count <= 1)
            {
                return;
            }
            foreach (Tier tier in _Tiere)
            {
                Tier? anderesTier = getRandomAnimalOtherThan(tier);
                if (anderesTier != null && rnd.Next(0, 10) <= 3 && Tiere.Count >= 2 && !anderesTier.Tot && !tier.Tot)
                {
                    Console.WriteLine("{0} hat {1} hp", anderesTier.Name, anderesTier.Gesundheit);
                    Console.WriteLine("{0} beißt {1} und {1} nimmt {2} Schaden.", tier, anderesTier.Name, tier.Biss);
                    anderesTier.Bite(tier.Biss);
                    Console.WriteLine("{0} hat {1} hp", anderesTier.Name, anderesTier.Gesundheit);
                    if (anderesTier.Tot)
                    {
                        animalsToRemove.Add(anderesTier);
                    }
                    Console.WriteLine();
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (Tier tier in animalsToRemove)
            {
                Console.WriteLine("{0} ist tot und wird beerdigt", tier.Name);
                Console.WriteLine();
                _Tiere.Remove(tier);
            }
            Console.ResetColor();
        }
        public Tier GetLowestHealth()
        {
            Tier lowestTier = null;
            foreach (Tier tier in Tiere)
            {
                if (lowestTier == null || (lowestTier.GetHealth()*100 / lowestTier.GetMaxHealth()*100) > (tier.GetHealth()*100 / tier.GetMaxHealth()*100))
                {
                    lowestTier = tier;
                }
            }
            return lowestTier;
        }
    }
}
