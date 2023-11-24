namespace DarioLuis.Museum
{
    public class Museum_Main
    {
        public static void Start()
        {
            Hallway eingang = new Hallway("Eingang");
            Museum museum = new Museum("Schloss von Gyula", 1869, eingang);

            Hallway gang1 = new Hallway("Van-Gogh-Gang");
            Hallway gang2 = new Hallway("Picasso-Gang");

            Austellungsraum r1 = new Austellungsraum("Gemälde", ConsoleColor.Green);
            Austellungsraum r2 = new Austellungsraum("Moderne Kunst", ConsoleColor.Blue);
            Austellungsraum r3 = new Austellungsraum("Antike", ConsoleColor.Yellow);
            Austellungsraum r4 = new Austellungsraum("Statuen", ConsoleColor.DarkCyan);
            Austellungsraum r5 = new Austellungsraum("Moderne Architektur", ConsoleColor.Cyan);
            Austellungsraum r6 = new Austellungsraum("Barock", ConsoleColor.Red);
            Austellungsraum r7 = new Austellungsraum("Abstrakte Kunst", ConsoleColor.DarkRed);

            eingang.Raumhinzu(gang1);
            gang1.Raumhinzu(gang2);
            eingang.Raumhinzu(r7);
            gang1.Raumhinzu(r1);
            gang2.Raumhinzu(r5);
            r3.Raumhinzu(gang2);
            r1.Raumhinzu(r2);
            r2.Raumhinzu(r4);
            r4.Raumhinzu(r3);
            r5.Raumhinzu(r6);
            r6.Raumhinzu(r7);
            

            museum.PrintStruktur("");

            //Ali
            Gast ali = new Gast("Ali", false);
            museum.Gasthinzu(ali);

            //Berna
            Gast berna = new Gast("Berna", false);
            museum.Gasthinzu(berna);

            //Dario
            Gast dario = new Gast("Dario", false);
            museum.Gasthinzu(dario);

            //David
            Gast david = new Gast("David", false);
            museum.Gasthinzu(david);

            //Dimitri
            Gast dimitri = new Gast("Dimitri", false);
            museum.Gasthinzu(dimitri);

            //Fabian
            Gast fabian = new Gast("Fabian", false);
            museum.Gasthinzu(fabian);

            //Selina
            Gast selina = new Gast("Selina", false);
            museum.Gasthinzu(selina);

            //Niklas
            Gast niklas = new Gast("Niklas", false);
            museum.Gasthinzu(niklas);

            //Riccardo
            Gast riccardo = new Gast("Riccardo", false);
            museum.Gasthinzu(riccardo);

            //Eren
            Gast eren = new Gast("Eren", false);
            museum.Gasthinzu(eren);

            //Cemal
            Gast cemal = new Gast("Cemal", false);
            museum.Gasthinzu(cemal);

            //Timo
            Gast timo = new Gast("Timo", true);
            museum.Gasthinzu(timo);

            for (int i = 0; i < 10; i++)
            {
                museum.Tick();
            }



            


            //Kunststücke
            Kunststuecke doctorschnabel = new Kunststuecke("Doctor Schnabel in Rom", 1656, "Ein Pestdoktor", "Barock");
            Kunststuecke lukasarr = new Kunststuecke("Arr-Piratenlegende", 2023, "Lukas Eichbaumer", "Moderne Kunst");
            Kunststuecke bubblesort = new Kunststuecke("Bubble-Sortieren", 1999, "Sandro Boso", "Abstrakte Kunst");


        }

    }
}
