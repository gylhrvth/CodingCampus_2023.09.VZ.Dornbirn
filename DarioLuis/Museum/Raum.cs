using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Museum
{
    public abstract class Raum
    {
        private static Random rand = new Random();
        public string Name { get; set; }


        public List<string> Kunststücke;
        public List<Gast> Gaeste;
        public List<Raum> NachbarRaeume;
        

        public Raum(string name)
        {
            Name = name;
            Gaeste = new List<Gast>();
            Kunststücke = new List<string>();
            NachbarRaeume = new List<Raum>();
        }

        public void RaumVerlassen(Gast gast)
        {
            //Console.WriteLine($"{gast.Name} verlässt den Raum {Name}.");
            if (Gaeste.Contains(gast))
            {
                Gaeste.Remove(gast);
            }
        }
        public void RaumEintreten(Gast gast)
        {
            Console.WriteLine($"{gast.Name} tritt in den Raum {Name} ein.");
            if (!Gaeste.Contains(gast))
            {
                Gaeste.Add(gast);
            }
        }

        
        public void Raumhinzu(Raum raum)
        {
            if (!NachbarRaeume.Contains(raum))
            {
                NachbarRaeume.Add(raum);
                raum.Raumhinzu(this);
            }
        }


        public abstract void PrintMich(string prefix);

        public void PrintStruktur(string prefix, List<Raum> besuchteRaeume)
        {
            if (!besuchteRaeume.Contains(this))
            {
                besuchteRaeume.Add(this);
                PrintMich(prefix);
                bool first = true;
                foreach (Raum r in NachbarRaeume)
                {
                    if (first)
                    {
                        Console.Write(" Nachbarräume: ");
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                    first = false;
                    Console.Write(r.Name);
                }
                Console.WriteLine();
                foreach (Raum r in NachbarRaeume)
                {
                    r.PrintStruktur(prefix, besuchteRaeume);
                }
            }
        }


        public Raum GibEinNachbarRaum()
        {
            Raum r = null;
            if (NachbarRaeume.Count > 0)
            {
                r = NachbarRaeume[rand.Next(NachbarRaeume.Count)];
            }
            return r;
        }
    }
}
