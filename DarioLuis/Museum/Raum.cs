using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Museum
{
    public abstract class Raum
    {
        public string Name { get; set; }


        public List<string> Kunststücke;
        public List<Gast> Gaeste;
        public List<Raum> Raeume;
        

        public Raum(string name)
        {
            Name = name;
            Gaeste = new List<Gast>();
            Kunststücke = new List<string>();
            Raeume = new List<Raum>();
        }

        public void RaumVerlassen(Gast gaeste)
        {
            if (!Gaeste.Contains(gaeste))
            {
                Gaeste.Add(gaeste);
                Console.WriteLine($"{gaeste.Name} verlässt den Raum {Name}.");
            }
        }
        public void GebaeudeVerlassen(Gast gaeste)
        {
            if (!Gaeste.Contains(gaeste))
            {
                Gaeste.Remove(gaeste);
                Console.WriteLine($"{gaeste.Name} hat das Museum verlassen.");
            }
        }

        public void GebaeudeBetreten(Gast gaeste)
        {
            if (!Gaeste.Contains(gaeste))
            {
                Gaeste.Add(gaeste);
                Console.WriteLine($"{gaeste.Name} hat das Museum betreten");
            }
        }
        
        public void Raumhinzu(Raum austellungsräume)
        {
            if (!Raeume.Contains(austellungsräume))
            {
                Raeume.Add(austellungsräume);
                austellungsräume.Raumhinzu(this);
            }
        }


        public void Gebaeudeplan(string index, List<Raum> besucht)
        {
            if (!besucht.Contains(this))
            {
                besucht.Add(this);
                AufenthaltsOrt(index);
                bool first = true;
                foreach(Raum a in Raeume )
                {
                    first = false;
                    Console.WriteLine(a.Name);
                }
                foreach(Raum b in Raeume)
                {
                    b.Gebaeudeplan(index, besucht);
                }
            }

        }

        public abstract void AufenthaltsOrt(string index);


        

        
    }
}
