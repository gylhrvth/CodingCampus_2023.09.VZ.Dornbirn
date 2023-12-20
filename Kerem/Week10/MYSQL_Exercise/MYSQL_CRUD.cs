using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Kerem.Week10.MYSQL_Exercise
{
    internal class MYSQL_CRUD
    {
        public static void Start()
        {
            // Beispiel für die Verwendung der Land-Klasse und ihrer Methoden
            List<MYSQL_Land> datenbank = new List<MYSQL_Land>();

            // Land hinzufügen
            MYSQL_Land.LandHinzufügen(datenbank, "Wano", "Kuni", 83000000);

            // Land suchen
            MYSQL_Land gefundenesLand = MYSQL_Land.LandFinden(datenbank, "Wano");
            Console.WriteLine($"Gefundenes Land: {gefundenesLand.Name}, Hauptstadt: {gefundenesLand.Hauptstadt}, Bevölkerung: {gefundenesLand.Bevölkerung}");

            // Attribut ändern
            gefundenesLand.AttributVerändern("hauptstadt", "Egghead");
            Console.WriteLine($"Geänderte Hauptstadt: {gefundenesLand.Hauptstadt}");

            // Land löschen
            MYSQL_Land.LandLöschen(datenbank, "Wano");

            // Ausgabe der verbleibenden Länder in der Datenbank
            Console.WriteLine("Verbleibende Länder in der Datenbank:"); 
            foreach (MYSQL_Land land in datenbank)
            {
                Console.WriteLine($"Name: {land.Name}, Hauptstadt: {land.Hauptstadt}, Bevölkerung: {land.Bevölkerung}");
            }
        }


    }
    
}
