using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week10.MYSQL_Exercise
{


    internal class MYSQL_Land
    {
        public string Name { get; set; }
        public string Hauptstadt { get; set; }
        public double Bevölkerung { get; set; }

        // Konstruktor
        public MYSQL_Land(string name, string hauptstadt, double bevölkerung)
        {
            Name = name;
            Hauptstadt = hauptstadt;
            Bevölkerung = bevölkerung;
        }

        // Methode zum Hinzufügen eines neuen Landes in die Datenbank
        public static void LandHinzufügen(List<MYSQL_Land> datenbank, string name, string hauptstadt, double bevölkerung)
        {
            MYSQL_Land neuesLand = new MYSQL_Land(name, hauptstadt, bevölkerung);
            datenbank.Add(neuesLand);
            Console.WriteLine($"{name} wurde zur Datenbank hinzugefügt.");
        }

        // Methode zum Suchen eines bestimmten Landes in der Datenbank
        public static MYSQL_Land LandFinden(List<MYSQL_Land> datenbank, string name)
        {
            return datenbank.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Methode zum Verändern eines bestimmten Attributs eines Landes
        public void AttributVerändern(string attribut, string neuerWert)
        {
            switch (attribut.ToLower())
            {
                case "name":
                    Name = neuerWert;
                    break;
                case "hauptstadt":
                    Hauptstadt = neuerWert;
                    break;
                case "bevölkerung":
                    Bevölkerung = Convert.ToDouble(neuerWert);
                    break;
                default:
                    Console.WriteLine($"Ungültiges Attribut: {attribut}");
                    break;
            }
        }

        // Methode zum Löschen eines bestimmten Landes aus der Datenbank
        public static void LandLöschen(List<MYSQL_Land> datenbank, string name)
        {
            MYSQL_Land land = LandFinden(datenbank, name);
            if (land != null)
            {
                datenbank.Remove(land);
                Console.WriteLine($"{name} wurde aus der Datenbank gelöscht.");
            }
            else
            {
                Console.WriteLine($"{name} konnte nicht in der Datenbank gefunden werden.");
            }
        }
    }

}
