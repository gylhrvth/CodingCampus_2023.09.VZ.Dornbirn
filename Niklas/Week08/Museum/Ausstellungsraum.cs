using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Museum
{
    public class Ausstellungsraum : Museum
    {
        public string _Name;
        public List<string> KunstStücke;
        public List<Gaeste> Gaeste;
        public List<Ausstellungsraum> Raeume;

        public Ausstellungsraum(string name)
        {
            _Name = name;
        }
        public void Verlassen(Gaeste gaeste)
        {
            if (!Gaeste.Contains(gaeste))
            {
                Gaeste.Add(gaeste);
                Console.WriteLine($"{gaeste.Name} verlässt den Raum {_Name}");
            }
        }
    }
}
