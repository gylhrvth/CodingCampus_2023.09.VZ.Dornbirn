using System;
using System.Collections.Generic;
using System.Linq;
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
            
            List<ZooClass> ZooListe = new List<ZooClass>();
            List<EnclosureClass> EnclosureList = new List<EnclosureClass>();

            List<AnimalClass> AnimalList = new List<AnimalClass>(); //TierListe erstellen

            
            ZooClass Zoo = new ZooClass("Montags Zoo", 1999);

            ZooListe.Add(Zoo);

            Futter Fleisch = new Futter("Fleisch", "kg", 10);
            Futter Mäuse = new Futter("Mäuse", "stück", 100);
            Futter Fisch = new Futter("Fisch", "kg", 25);

            Console.WriteLine();

            AnimalClass Animal1 = new AnimalClass("Polo", "Pinguin🐧",123213,Fisch);
            Zoo.AddAnimal(Animal1);

            AnimalClass Animal2 = new AnimalClass("Erik", "Hund🐕" ,43231,Fleisch);
            Zoo.AddAnimal(Animal2);

            AnimalClass Animal3 = new AnimalClass("Polo", "Adler🦅", 2,Mäuse);
            Zoo.AddAnimal(Animal2);

       


            EnclosureClass Enclosure1 = new EnclosureClass("WinterTiere⛄", "OutDoor"); //erstelle ein Gehäge
            EnclosureClass Enclosure2 = new EnclosureClass("HausTiere🏠", "InDoor"); //erstelle ein Gehäge
            EnclosureClass Enclosure3 = new EnclosureClass("FlugTiere🌠", "OutDoor/Sky"); //erstelle ein Gehäge

            Enclosure1.AddAnimal(Animal1);
            Enclosure2.AddAnimal(Animal2);


            //Enclosure3.AddAnimal(Animal3);

            Zoo.AddEnclosure(Enclosure1);
            Zoo.AddEnclosure(Enclosure2);
            Zoo.AddEnclosure(Enclosure3);
         

            Zoo.PrintZoo();
            Console.WriteLine();

            int kosten = Zoo.PrintEnclosures();
            Console.WriteLine("Kosten:" + kosten);

            Zoo.PrintFoodReport();

        }
    }
}
