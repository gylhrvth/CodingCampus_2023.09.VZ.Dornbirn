namespace DarioLuis.Museum
{
    public class Museum_Main
    {
        public static void Start()
        {
            Hallway eingang = new Hallway("Eingang");
            Museum museum = new Museum("Schloss vo" +
                "n Gyulalia", 1869, eingang);

            Austellungsraum r1 = new Austellungsraum("Gemälde");
            Austellungsraum r2 = new Austellungsraum("Moderne Kunst");

            eingang.Raumhinzu(r1);
            r1.Raumhinzu(r2);

            museum.PrintStruktur("");

            Gast ali = new Gast("Ali", false);
            museum.Gasthinzu(ali);

            Gast berna = new Gast("Berna", false);
            museum.Gasthinzu(berna);

            for (int i = 0; i < 10; i++)
            {
                museum.Tick();
            }


            /*

            //Gäste
            Gast cemal = new Gast("Cemal", true);
            Gast dario = new Gast("Dario", true);
            Gast david = new Gast("David", false);
            Gast dimitri = new Gast("Dimitri", false);
            Gast fabian = new Gast("Fabian", true);
            Gast selina = new Gast("Selina", false);
            Gast niklas = new Gast("Niklas", false);
            Gast riccardo = new Gast("Riccardo", true);
            Gast eren = new Gast("Eren", true);

            //Gäste hinzugefugt
            museum.Gasthinzu(ali);
            museum.Gasthinzu(berna);
            museum.Gasthinzu(cemal);
            museum.Gasthinzu(dario);
            museum.Gasthinzu(david);
            museum.Gasthinzu(dimitri);
            museum.Gasthinzu(fabian);
            museum.Gasthinzu(selina);
            museum.Gasthinzu(niklas);
            museum.Gasthinzu(riccardo);
            museum.Gasthinzu(eren);



            
            //Räume
            Austellungsraum r1 = new Austellungsraum("Gemälde");
            Austellungsraum r2 = new Austellungsraum("Moderne Kunst");
            Austellungsraum r3 = new Austellungsraum("Antike");
            Austellungsraum r4 = new Austellungsraum("Statuen");
            Austellungsraum r5 = new Austellungsraum("Moderne Architektur");
            Austellungsraum r6 = new Austellungsraum("Barock");
            Austellungsraum r7 = new Austellungsraum("Abstrakte Kunst");

            //Gänge
            Hallway eingang = new Hallway("Eingang");
            Hallway gang1 = new Hallway("Van-Gogh-Gang");
            Hallway gang2 = new Hallway("Picasso-Gang");

            //Eingan hinzufügen
            eingang.Raumhinzu(r7);
            r7.Raumhinzu(eingang);

            eingang.Raumhinzu(gang1);
            gang1.Raumhinzu(eingang);

            gang1.Raumhinzu(r1);
            r1.Raumhinzu(gang1);

            gang2.Raumhinzu(gang1);
            gang1.Raumhinzu(gang2);

            r2.Raumhinzu(r1);
            r1.Raumhinzu(r2);

            r4.Raumhinzu(r2);
            r2.Raumhinzu(r4);

            r4.Raumhinzu(r3);
            r3.Raumhinzu(r4);

            gang2.Raumhinzu(r3);
            r3.Raumhinzu(gang2);

            r5.Raumhinzu(gang2);
            gang2.Raumhinzu(r5);

            r6.Raumhinzu(r5);
            r5.Raumhinzu(r6);

            r7.Raumhinzu(r6);
            r6.Raumhinzu(r7);

            


            //Kunststücke
            Kunststuecke doctorschnabel = new Kunststuecke("Doctor Schnabel in Rom", 1656, "Ein Pestdoktor", "Barock");
            
            */


        }

    }
}
