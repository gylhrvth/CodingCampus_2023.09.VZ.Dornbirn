using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Simon.Week06.Zoo3;

namespace Simon.Week06.Zoo3
{
    internal class AnimalDoctor
    {
        Random rand = new Random();
        private string _Name;
        private List<Animals> _AnimalsList;


        public AnimalDoctor(string name)
        {
            _Name = name;
            _AnimalsList = new();
        }
        public void PrintAnimalDocotor()
        {
            Console.WriteLine("│\t\t├── {0}", _Name);
        }



        public void RestoreHP(Animals lowesthp)
        {
            double healammount = (double)rand.Next(30, 100) / 100;
            if(lowesthp.Health + (lowesthp.MaxHealth * healammount) > lowesthp.MaxHealth)
            {
                lowesthp.Health = lowesthp.MaxHealth;
                Console.WriteLine("{0} hat {1} um geheilt. Es hat nun wider volle ({2}) Leben.", _Name, lowesthp.Name, lowesthp.Health);
            }
            else
            {
                lowesthp.Health = (int)(lowesthp.Health + (lowesthp.MaxHealth * healammount));
                Console.WriteLine("{0} hat {1} geheilt. Es hat nun {2} Leben.", _Name, lowesthp.Name, lowesthp.Health);

            }

        }

    }
}
