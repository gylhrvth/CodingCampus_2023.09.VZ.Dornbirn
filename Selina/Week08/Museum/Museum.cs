using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.Museum
{
    public class Museum
    {
        private string Name;
        private Gang Gang;
        private Raum Kunstraum;
        private int Year;
        private List<Gast> Gaeste;
        private List<Raum> RaumList;

        public Museum(string name, int year)
        {
            this.Name = name;
            this.Gaeste = new List<Gast>();
            this.RaumList = new List<Raum>();
            this.Year = year;
        }

        public void StrukturDrucken(string index)
        {
            Console.WriteLine($"{index} Unser Museum: {Name} in {Year} gegründet");
            List<Raum> raumBesucht = new List<Raum>();
            Gang.StrukturDrucken(index + "    ", raumBesucht);
        }

        public void AddGuest(Gast g)
        {
            if (!Gaeste.Contains(g))
            {
                Gaeste.Add(g);
                g.GehtZu(Gang);
            }
        }

        public void AddRaumBesucht(Raum raum)
        {
            if (!RaumList.Contains(raum))
            {
                RaumList.Add(raum);
            }
        }
    }
}
