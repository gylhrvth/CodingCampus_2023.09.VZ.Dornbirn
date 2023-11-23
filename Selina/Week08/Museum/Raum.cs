using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.Museum
{
    public abstract class Raum
    {
        protected string Name;
        private List<Raum> RaumNebenAn;
        private List<Gast> Gast;

        protected Raum(string name)
        {
            this.Name = name;
            this.RaumNebenAn = new List<Raum>();
            this.Gast = new List<Gast>();
        }

        public void GastKommt(Gast gast)
        {
            if (!Gast.Contains(gast))
            {
                Gast.Add(gast);

                Console.WriteLine($"{gast.Name} kommt zum Raum: {Name}");
            }
        }

        public void GastGeht(Gast gast)
        {
            if (Gast.Contains(gast))
            {
                Gast.Remove(gast);
            }
        }

        public void RaumHinzufügen(Raum andererRaum)
        {
            if (!RaumNebenAn.Contains(andererRaum))
            {
                RaumNebenAn.Add(andererRaum);
                andererRaum.RaumHinzufügen(this);
            }
        }

        protected abstract void GangOfMuseum(string index);

        public void StrukturDrucken(string index, List<Raum> besucht)
        {
            if (!besucht.Contains(this))
            {
                besucht.Add(this);
                GangOfMuseum(index);
                Console.Write(" Nachbaren: ");
                bool first = true;
                foreach (Raum r in RaumNebenAn)
                {
                    if (!first)
                    {
                        Console.Write(", ");
                    }
                    first = false;
                    Console.Write(r.Name);
                }
                Console.WriteLine();

                foreach (Raum r in RaumNebenAn)
                {
                    r.StrukturDrucken(index, besucht);
                }
            }
        }
    }
}

