using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class ZooExample
    {
        public static void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<ZooClass> list = new List<ZooClass>();
            List<EnclosureClass> EnclosureList = new List<EnclosureClass>();

            List<AnimalClass> AnimalList = new List<AnimalClass>();

            ZooClass Zoo = new ZooClass("Montags Zoo", 1999);

            

            list.Add(Zoo);

            Console.WriteLine();

            AnimalClass Animal1 = new AnimalClass("Polo", "Pinguin🐧");
            Zoo.AddAnimal(Animal1);

            AnimalClass Animal2 = new AnimalClass("Erik", "Hund🐕");
            Zoo.AddAnimal(Animal2);


            EnclosureClass Enclosure1 = new EnclosureClass("WinterTiere", "OutDoor"); //erstelle ein Gehäge

            EnclosureClass Enclosure2 = new EnclosureClass("HausTiere", "OutDoor"); //erstelle ein Gehäge

            Enclosure1.AddAnimal(Animal1);
            Enclosure2.AddAnimal(Animal2);
            
            Zoo.AddEnclosure(Enclosure1);
            Zoo.AddEnclosure(Enclosure2);
           
            
           

        

            Zoo.PrintZoo();
            Console.WriteLine();
            Zoo.PrintEnclosures();


            

        }
    }
}
