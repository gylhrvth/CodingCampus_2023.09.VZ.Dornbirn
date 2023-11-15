using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo wildPark = new Zoo("Wildpark", 2023);

            Gehege alpenwiese = new Gehege("Alpenwiese");
            Gehege ried = new Gehege("Ried");
            Gehege alpen = new Gehege("Alpen");
            Gehege wald = new Gehege("Wald");
            Gehege katze = new Gehege("Katzen");
            Gehege vogelkäfig = new Gehege("Vogelkäfig");

            Futter gras = new Futter("Gras", "kg", 0.23);
            Futter maus = new Futter("Maus", "Stück", 0.9);
            Futter alpenkräuter = new Futter("Alpenkräuter", "kg", 0.35);
            Futter fleisch = new Futter("Fleisch", "kg", 3.60);
            Futter körner = new Futter("Körner", "Tassen", 0.10);

            Tier rijska = new Tier("Rijska", "Esel", gras, 37, 75, 15);
            Tier agata = new Tier("Agata", "Esel", gras, 35, 75, 15);
            Tier cleo = new Tier("Cleo", "Zwergziege", gras, 15, 60, 10);
            Tier misty = new Tier("Misty", "Zwergziege", gras, 15, 60, 10);
            Tier micha = new Tier("Micha", "Zwergziege", gras, 11, 60, 10);
            Tier heidi = new Tier("Heidi", "Kuh", gras, 40, 70, 12);
            Tier bella = new Tier("Bella", "Kuh", gras, 40, 70, 12);
            Tier fiona = new Tier("Fiona", "Kuh", gras, 40, 70, 12);
            Tier garmond = new Tier("Garmond", "Storch", maus, 10, 45, 7);
            Tier hugo = new Tier("Hugo", "Storch", maus, 15, 45, 14);
            Tier idaxis = new Tier("Idaxis", "Storch", maus, 5, 45, 7);
            Tier joris = new Tier("Joris", "Steinbock", alpenkräuter, 40, 65, 20);
            Tier miron = new Tier("Miron", "Steinbock", alpenkräuter, 40, 65, 20);
            Tier elwin = new Tier("Elwin", "Steinbock", alpenkräuter, 40, 65, 20);
            Tier eduard = new Tier("Eduard", "Steinbock", alpenkräuter, 40, 65, 20);
            Tier andreas = new Tier("Andreas", "Steinbock", alpenkräuter, 40, 65, 20);
            Tier fenris = new Tier("Fenris", "Wolf", fleisch, 15, 77, 25);
            Tier geri = new Tier("Geri", "Wolf", fleisch, 13, 77, 25);
            Tier freki = new Tier("Freki", "Wolf", fleisch, 15, 77, 25);
            Tier akay = new Tier("Akay", "Wolf", fleisch, 22, 77, 25);
            Tier maya = new Tier("Maya", "Wolf", fleisch, 11, 77, 25);
            Tier freddi = new Tier("Freddi", "Wildkatze", maus, 25, 40, 15);
            Tier sam = new Tier("Sam", "Wildkatze", maus, 21, 40, 15);
            Tier scotty = new Tier("Scotty", "Wildkatze", maus, 27, 40, 15);
            Tier luca = new Tier("Luca", "Luchs", fleisch, 10, 55, 25);
            Tier yukiko = new Tier("Yukiko", "Luchs", fleisch, 9, 55, 25);
            Tier rufus = new Tier("Rufus", "Luchs", fleisch, 5, 55, 25);
            Tier tick = new Tier("Tick", "Auerhuhn", körner, 4, 32, 5);
            Tier trick = new Tier("Trick", "Auerhuhn", körner, 5, 32, 5);
            Tier track = new Tier("Track", "Auerhuhn", körner, 4, 32, 5);
            Tier uhustick = new Tier("Uhu-Stick", "Uhu", maus, 5, 35, 13);
            Tier tixo = new Tier("Tixo", "Uhu", maus, 5, 35, 13);

            Tierpfleger günther = new Tierpfleger("Günther", new List<Gehege> { alpenwiese, vogelkäfig, ried }, tixo);
            Tierpfleger franz = new Tierpfleger("Franz", new List<Gehege> { ried, alpen }, rufus);
            Tierpfleger felix = new Tierpfleger("Felix", new List<Gehege> { katze, wald, vogelkäfig });
            Tierpfleger jurgen = new Tierpfleger("Jürgen", new List<Gehege> { alpenwiese });

            Tierarzt hans = new Tierarzt("Hans");
            Tierarzt joerg = new Tierarzt("Jörg");
            Tierarzt henriette = new Tierarzt("Henriette");

            wildPark.Tierarzt.Add(hans);
            wildPark.Tierarzt.Add(joerg);
            wildPark.Tierarzt.Add(henriette);
            

            //    rijska.FoodList.Add(gras);
            //    agata.FoodList.Add(gras);
            //    cleo.FoodList.Add(gras);
            //    misty.FoodList.Add(gras);
            //    micha.FoodList.Add(gras);
            //    heidi.FoodList.Add(gras);
            //    bella.FoodList.Add(gras);
            //    fiona.FoodList.Add(gras);
            //    garmond.FoodList.Add(maus);
            //    hugo.FoodList.Add(maus);
            //    idaxis.FoodList.Add(maus);
            //    joris.FoodList.Add(alpenkräuter);
            //    miron.FoodList.Add(alpenkräuter);
            //    elwin.FoodList.Add(alpenkräuter);
            //    eduard.FoodList.Add(alpenkräuter);
            //    andreas.FoodList.Add(alpenkräuter);
            //    fenris.FoodList.Add(fleisch);
            //    geri.FoodList.Add(fleisch);
            //    freki.FoodList.Add(fleisch);
            //    akay.FoodList.Add(fleisch);
            //    maya.FoodList.Add(fleisch);
            //    freddi.FoodList.Add(maus);
            //    sam.FoodList.Add(maus);
            //    scotty.FoodList.Add(maus);
            //    luca.FoodList.Add(fleisch);
            //    yukiko.FoodList.Add(fleisch);
            //    rufus.FoodList.Add(fleisch);
            //    tick.FoodList.Add(körner);
            //    trick.FoodList.Add(körner);
            //    track.FoodList.Add(körner);
            //    uhustick.FoodList.Add(maus);
            //    tixo.FoodList.Add(maus);

            wildPark.Gehege.Add(alpenwiese);
            wildPark.Gehege.Add(ried);
            wildPark.Gehege.Add(alpen);
            wildPark.Gehege.Add(wald);
            wildPark.Gehege.Add(katze);
            wildPark.Gehege.Add(vogelkäfig);

            wildPark.Tierpfleger.Add(jurgen);
            wildPark.Tierpfleger.Add(günther);
            wildPark.Tierpfleger.Add(franz);
            wildPark.Tierpfleger.Add(felix);

            alpenwiese.Tier.Add(rijska);
            alpenwiese.Tier.Add(agata);
            alpenwiese.Tier.Add(cleo);
            alpenwiese.Tier.Add(misty);
            alpenwiese.Tier.Add(micha);
            alpenwiese.Tier.Add(heidi);
            alpenwiese.Tier.Add(bella);
            alpenwiese.Tier.Add(fiona);
            ried.Tier.Add(garmond);
            ried.Tier.Add(hugo);
            ried.Tier.Add(idaxis);
            alpen.Tier.Add(joris);
            alpen.Tier.Add(miron);
            alpen.Tier.Add(elwin);
            alpen.Tier.Add(eduard);
            alpen.Tier.Add(andreas);
            wald.Tier.Add(fenris);
            wald.Tier.Add(geri);
            wald.Tier.Add(freki);
            wald.Tier.Add(akay);
            wald.Tier.Add(maya);
            katze.Tier.Add(freddi);
            katze.Tier.Add(sam);
            katze.Tier.Add(scotty);
            katze.Tier.Add(luca);
            katze.Tier.Add(yukiko);
            katze.Tier.Add(rufus);
            vogelkäfig.Tier.Add(tick);
            vogelkäfig.Tier.Add(trick);
            vogelkäfig.Tier.Add(track);
            vogelkäfig.Tier.Add(uhustick);
            vogelkäfig.Tier.Add(tixo);



            
            Simulation03(wildPark, 65);
            
        }
        public static void Simulation01(Zoo zoo, int daysOfSimulation)
        {
            for (int i = 1; i <= daysOfSimulation; i++)
            {
                Console.WriteLine("{0}. Tag der Simulation: \n", i);
                zoo.PrintZoo();
                Console.WriteLine();
                zoo.PrintZooStatistic();
                Console.WriteLine();
                zoo.TierPflegerFuettern();
                if (i != daysOfSimulation)
                {
                    Console.WriteLine("\n\n\n\n");
                }
            }
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Ende der Simulation nach {0} Tagen: ", daysOfSimulation);
            zoo.PrintZoo();
            Console.WriteLine("Gesamtkosten für das Futter für die Gesamtdauer der Simulation: {0}€",zoo.GesamtFutterKosten) ;
        }

        public static void Simulation02(Zoo zoo, int daysOfSimulation)
        {
            for (int i = 1; i <= daysOfSimulation; i++)
            {
                Console.WriteLine("{0}. Tag der Simulation: \n", i);
                zoo.PrintZoo();
                Console.WriteLine();
                zoo.PrintZooStatistic();
                Console.WriteLine();
                zoo.TierPflegerFuettern();
                zoo.Kampf();
                zoo.RemoveDeadAnimal();
                if (i != daysOfSimulation)
                {
                    Console.WriteLine("\n\n\n\n");
                    zoo.ResetGefuettert();
                }   
            }
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Ende der Simulation nach {0} Tagen: ", daysOfSimulation);
            zoo.PrintZoo();
            Console.WriteLine("Gesamtkosten für das Futter für die Gesamtdauer der Simulation: {0 :N2}€", zoo.GesamtFutterKosten);
        }

        public static void Simulation03(Zoo zoo, int daysOfSimulation)
        {
            for (int i = 1; i <= daysOfSimulation; i++)
            {
                Console.WriteLine("{0}. Tag der Simulation: \n", i);
                zoo.PrintZoo();
                Console.WriteLine();
                zoo.PrintZooStatistic();
                Console.WriteLine();
                zoo.TierPflegerFuettern();
                zoo.Kampf();
                zoo.Heilen();
                zoo.RemoveDeadAnimal();
                if (i != daysOfSimulation)
                {
                    Console.WriteLine("\n\n\n\n");
                    zoo.ResetGefuettert();
                } 
            }
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Ende der Simulation nach {0} Tagen: ", daysOfSimulation);
            zoo.PrintZoo();
            Console.WriteLine("Gesamtkosten für das Futter für die Gesamtdauer der Simulation: {0 :N2}€", zoo.GesamtFutterKosten);
            Console.WriteLine("Liste der verstorbenenen Tiere:");
            zoo.DeadAnimals();
        }
    }
}
