using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class ZooMain
    {
        public static void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Zoo> ZooListe = new List<Zoo>();
            //List<Enclosure> EnclosureList = new List<Enclosure>();
            List<Pfleger> PflegerListe = new List<Pfleger>();
            List<Animal> AnimalList = new List<Animal>(); //TierListe erstellen


            Zoo Zoo = new Zoo("Montags Zoo", 1999);

            ZooListe.Add(Zoo);

            Futter Fleisch = new Futter("Fleisch", "kg", 10);
            Futter Mäuse = new Futter("Mäuse", "stück", 100);
            Futter Fisch = new Futter("Fisch", "kg", 25);

            Console.WriteLine();

            Animal Animal1 = new Animal("Polo", "Pinguin🐧", 12, Fisch, "Fisch", 50, 4);
            Zoo.AddAnimal(Animal1);

            Animal Animal2 = new Animal("Erik", "Hund🐕", 4, Fleisch, "Fleisch", 80, 7);
            Zoo.AddAnimal(Animal2);

            Animal Animal3 = new Animal("Aldi", "Adler🦅", 2, Mäuse, "lebende Mäuse", 90, 10);
            Zoo.AddAnimal(Animal2);

            Pfleger sandra = new Pfleger("Sandra", 22, "weiblich");
            Pfleger marko = new Pfleger("marko", 12, "Divers");


            Enclosure Enclosure1 = new Enclosure("WinterTiere⛄", "OutDoor", sandra, true); //erstelle ein Gehäge
            Enclosure Enclosure2 = new Enclosure("HausTiere🏠", "InDoor", marko, false); //erstelle ein Gehäge
            Enclosure Enclosure3 = new Enclosure("FlugTiere🌠", "OutDoor/Sky", marko, true); //erstelle ein Gehäge


            Enclosure1.AddAnimal(Animal1);
            Enclosure2.AddAnimal(Animal2);
            Enclosure3.AddAnimal(Animal3);


            Zoo.AddEnclosure(Enclosure1);
            Zoo.AddEnclosure(Enclosure2);
            Zoo.AddEnclosure(Enclosure3);

            Enclosure1.AddPfleger(sandra);
            Enclosure2.AddPfleger(marko);
            Enclosure3.AddPfleger(marko);

            Zoo.PrintZoo();
            Console.WriteLine();

            int kosten = Zoo.PrintEnclosures();
            Console.WriteLine();
            Console.WriteLine("Kosten:" + kosten + "€");

            Zoo.PrintFoodReport();

            Console.WriteLine();

            //foreach (Enclosure enclosure in EnclosureList)
            //{
            //    if (enclosure.IsFed == false)
            //    {
            //        enclosure.Feed();
            //        enclosure.IsFed = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Dieses Gehege ist schon gefüttert");
            //    }
            //}
        }
    }
}
