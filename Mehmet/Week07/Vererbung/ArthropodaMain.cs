using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week08.Vererbung
{
    internal class ArthropodaMain
    {
        public static void Start()
        {
            List<Arthropoda> arthropodasorts = new List<Arthropoda>();

            arthropodasorts.Add(new Arthropoda("Acari"));
            arthropodasorts.Add(new Arthropoda("Amblypygi"));
            arthropodasorts.Add(new Arthropoda("Araneae"));
            arthropodasorts.Add(new Arthropoda("Opiliones"));
            arthropodasorts.Add(new Arthropoda("Scorpiones"));
            arthropodasorts.Add(new Arthropoda("Xiphosura"));
            arthropodasorts.Add(new Scorpiones("Babycurus jacksoni", true));
            arthropodasorts.Add(new Scorpiones("Parabuthus transvaalicus", true));
            arthropodasorts.Add(new Araneae("Abacoproeces saltuum", false));
            arthropodasorts.Add(new Araneae("Acantholycosa lignaria", true));
            arthropodasorts.Add(new Araneae("Aculepeira ceropegia", false));

            foreach (Arthropoda art in arthropodasorts)
            {
                art.PrintMe();
            }


        }




    }
}
