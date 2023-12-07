using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week11.SQL_CRUD
{
    internal class Land
    {
        public string Name { get; set; }
        public string Hauptstadt { get; set; }
        public double Bevölkerung { get; set; }

        public Land(string name, string hauptstadt, double bevölkerung)
        {
            Name = name;
            Hauptstadt = hauptstadt;
            Bevölkerung = bevölkerung;
        }

        public static void LandHinzufügen(List<Land> datenbank, string name, string hauptstadt, double bevölkerung)
        {
            Land neuesLand = new Land(name, hauptstadt, bevölkerung);
            datenbank.Add(neuesLand);
            Console.WriteLine($"{name} wurde zur Datenbank hinzugefügt.");
        }

        public static Land LandFinden(List<Land> datenbank, string name)
        {
            return datenbank.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void AttributVerändern(string attribut, string neuerWert)
        {
            switch (attribut)
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
        public static void LandLöschen(List<Land> datenbank, string name)
        {
            Land land = LandFinden(datenbank, name);
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

