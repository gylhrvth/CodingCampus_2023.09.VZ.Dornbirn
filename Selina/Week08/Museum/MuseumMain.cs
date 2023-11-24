using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.Museum
{
    public class MuseumMain
    {
        public static void Start()
        {
            //Museum
            Museum museum = new Museum("Unser Museum", 1762);

            //unsere Gänge
            Gang gang1 = new Gang("Gang 1");
            Gang gang2 = new Gang("Gang 2");
            Gang gang3 = new Gang("Gang 3");
            Gang eingang = new Gang("Eingang");

            // unsere Räume
            Kunstraum r1 = new Kunstraum("Raum 1");
            Kunstraum r2 = new Kunstraum("Raum 2");
            Kunstraum r3 = new Kunstraum("Raum 3");
            Kunstraum r4 = new Kunstraum("Raum 4");
            Kunstraum r5 = new Kunstraum("Raum 5");
            Kunstraum r6 = new Kunstraum("Raum 6");
            Kunstraum r7 = new Kunstraum("Raum 7");

            r1.RaumHinzufügen(gang1);
            eingang.RaumHinzufügen(r7);
            r7.RaumHinzufügen(eingang);
            eingang.RaumHinzufügen(gang1);
            gang1.RaumHinzufügen(eingang);
            gang1.RaumHinzufügen(r1);
            r1.RaumHinzufügen(gang1);
            gang2.RaumHinzufügen(gang1);
            gang1.RaumHinzufügen(gang2);
            r2.RaumHinzufügen(r1);
            r1.RaumHinzufügen(r2);
            r4.RaumHinzufügen(r2);
            r2.RaumHinzufügen(r4);
            r4.RaumHinzufügen(r3);
            r3.RaumHinzufügen(r4);
            gang2.RaumHinzufügen(r3);
            r3.RaumHinzufügen(gang2);
            r5.RaumHinzufügen(gang2);
            gang2.RaumHinzufügen(r5);
            r6.RaumHinzufügen(r5);
            r5.RaumHinzufügen(r6);
            r7.RaumHinzufügen(r6);
            r6.RaumHinzufügen(r7);



            Gast ali = new Gast("Ali");
            Gast berna = new Gast("Berna");
            Gast cemal = new Gast("Cemal");
            Gast dario = new Gast("Dario");
            Gast david = new Gast("David");
            Gast dimitri = new Gast("Dimitri");
            Gast fabian = new Gast("Fabian");
            Gast selina = new Gast("Selina"); 
            Gast niklas = new Gast("Niklas");
            Gast riccardo = new Gast("Riccardo");

            museum.AddGuest(ali);
            museum.AddGuest(berna);
            museum.AddGuest(cemal);
            museum.AddGuest(dario);
            museum.AddGuest(david);
            museum.AddGuest(dimitri);
            museum.AddGuest(fabian);
            museum.AddGuest(selina);
            museum.AddGuest(niklas);
            museum.AddGuest(riccardo);

            
            museum.StrukturDrucken(""); ;

        }
    }
   
}

