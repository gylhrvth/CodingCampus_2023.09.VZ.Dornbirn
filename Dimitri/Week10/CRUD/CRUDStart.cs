using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week10.CRUD
{
    internal class CRUDStart
    {

        //Create, Read, Update, Delete

        // Erstelle eine Objekt-Klasse für ein Land und erstelle für jede Aufgabe eine eigene Methode die...

        //    ein neues Land erstellt und in die Datenbank einfügt.
        //    ein bestimmtes Land in der Datenbank findet.
        //    ein bestimmtest Attribut eines Landes verändert.
        //    ein bestimmtes Land aus der Datenbank löscht.

        //Bonus Aufgabe

        //    Erweitere dein Programm mit einer Console-Eingabe und teste deine Methoden.

        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=mondial;server=tcp:127.0.0.1,1433;User=dimitri;Password=sqlnew";

            Country goefnien = new("Göfnien", "GOF", "Göfis", "Göfis", 9.07, 3312.00);
           
            Database database = new(connectionString);

            try
            {
                database.Connect();

                database.DeleteCountry(goefnien._Code);

                database.CreateCountry(goefnien);

                Console.WriteLine("Country {0} exists: {1}", goefnien._Name, database.SearchCountry(goefnien._Name));

                database.DeleteCountry(goefnien._Code);

                Console.WriteLine("Country {0} exists: {1}", goefnien._Name, database.SearchCountry(goefnien._Name));

                database.Disconnect();
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
