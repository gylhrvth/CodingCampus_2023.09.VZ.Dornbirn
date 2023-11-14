using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    public class Tierarzt
    {
        private string _Name;

        public Tierarzt(string name) 
        {
            _Name = name;
        }

        public void Heilen(Tier tier)
        {
            Random random = new Random();
            int i = random.Next(30, 101);
            if (tier.HpPercent+i < 100) 
            {
                tier.HpPercent += i;
                tier.Hp= tier.HpPercent / 100 * tier.MaxHp;
            }
            else
            {
                tier.HpPercent = 100;
                tier.Hp = tier.MaxHp;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Die Gesundheit von {0} wurde auf {1 :N2}% geheilt", tier.Name, tier.HpPercent);
            Console.ResetColor();
        }
    }
}