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
        private bool _Gefüttert;


        public Gehege(string description)
        {
            _Description = description;
            _Tier = new List<Tier>();
            _Gefüttert = false;
        }

        public List<Tier> Tier
        {
            get => _Tier;
            //set => _Tier = value;
        }
        public string Description
        {
            get => _Description;
            //set => _Description = value;
        }
        public bool Gefüttert
        {
            get => _Gefüttert;
            set => _Gefüttert = value;
        }

        public void AddTier(Tier tier)
        {
            _Tier.Add(tier);
        }

        public void PrintGehege()
        {
            Console.WriteLine("│\t\t├── Gehege: {0}", _Description);
            for (int i = 0; i < _Tier.Count; i++)
            {
                _Tier[i].PrintTier();
            }
        }

        public void GetGehegeStatistic(Dictionary<Futter, double> dic)
        {
            for (int i = 0; i < _Tier.Count; i++)
            {
                _Tier[i].GetTierStatistic(dic);
            }
        }
    }
}
