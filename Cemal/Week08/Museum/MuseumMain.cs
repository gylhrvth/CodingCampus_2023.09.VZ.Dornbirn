using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week08.Museum
{
    public class MuseumMain
    {
        public static void Start()
        {
            Museum museum = new Museum("Pinakothek");

            ExhibitionRoom room1 = new("Bildergalerie");
            ExhibitionRoom room2 = new("Statuengalerie");
            ExhibitionRoom room3 = new("Kunstaustellungsraum");
            ExhibitionRoom room4 = new("Donisarierraum");
            ExhibitionRoom room5 = new("Steinzeitraum");

            Hallway hall1 = new Hallway("Gang1");
            MainHallway Hallmain = new MainHallway("Haupteingang");

            

        }
    }
}
