using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._05Zoo
{
    public class TierArzt
    {
        private string _Name;

        public TierArzt(string name)
        {
            _Name = name;
        }

        private static Random rnd = new Random();
        public static double GetRandomHealPercentage()
        {
            int heal = rnd.Next(30, 101);

            return (double)heal/100;
        }

        public void Heal(Tier lowestAnimal)
        {
            double healPercentage = GetRandomHealPercentage();

            double actualHeal = (double)lowestAnimal.GetMaxHealth() * GetRandomHealPercentage();

            int HealthBefore = lowestAnimal.GetHealth();

            lowestAnimal.Heal((int)actualHeal);

            int HealthAfter = lowestAnimal.GetHealth();

            int HealthDiff = HealthAfter - HealthBefore;

            if (HealthDiff > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} heilt {1} für {2}. Die neuen Lebenspunkte sind {3}.", _Name, lowestAnimal, HealthDiff, lowestAnimal.GetHealth());
                Console.ResetColor();
            } else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0} hatte nichts zu tun und geht nach Hause.", _Name);
                Console.ResetColor();
            }
        }
        
    }
}
