using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.ZooSimulation
{
    internal class Veterenarian
    {
        private string _Name;
        public string Name { get => _Name; }


        public void GoesHealing(Zoo zoo)
        {
            Animal mostHurt = null;

            foreach(Enclosure enc in zoo.Enclosures)
            {
                foreach(Animal animal in enc.Animals)
                {
                    if (mostHurt == null || (animal.CurrentHealth/animal.MaxHealth <= mostHurt.CurrentHealth/mostHurt.MaxHealth && animal.CurrentHealth > 0))
                    {
                        mostHurt = animal;
                    }
                }
            }
            if (mostHurt != null) mostHurt.GetsHealed(this);
        }


        public void CleanDeadAnimals(Zoo zoo)
        {
            foreach(Enclosure encl in zoo.Enclosures)
            {
                encl.GetsCleaned(this);
            }
        }


        public Veterenarian(string name)
        {
            _Name = name;
        }
    }
}
