using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week11.SQL_CRUD
{
    internal class SQL_LandMain
    {
        public static void Start()
        {
            List<Land> datenbank = new List<Land>();

            Land.LandHinzufügen(datenbank, "Alabasta", "Grandline" , 25528708);

            Land gefundenesLand = Land.LandFinden(datenbank, "Alabasta");
            Console.WriteLine($"Gefundenes Land: {gefundenesLand.Name}, Hauptstadt: {gefundenesLand.Hauptstadt}, Bevölkerung: {gefundenesLand.Bevölkerung}");

            gefundenesLand.AttributVerändern("Hauptstadt", "Alburna");
            Console.WriteLine($"Geänderte Hauptstadt: {gefundenesLand.Hauptstadt}");

            Land.LandLöschen(datenbank, "Alabasta");

        }
    }
}

