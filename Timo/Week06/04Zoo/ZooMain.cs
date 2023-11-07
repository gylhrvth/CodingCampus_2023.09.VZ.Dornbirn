using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo wildPark = new Zoo("Wildpark", 2023);
            ////Zoo schonbrunn = new Zoo("Schönbrunn", 1752);


            wildPark.AddGehege(new Gehege("Alpenwiese"));
            wildPark.AddGehege(new Gehege("Ried"));
            wildPark.AddGehege(new Gehege("Alpen"));
            wildPark.AddGehege(new Gehege("Wald"));
            wildPark.AddGehege(new Gehege("Katzen"));
            wildPark.AddGehege(new Gehege("Vogelkäfig"));

            wildPark.SearchAndCreate("Ried");
            wildPark.SearchAndCreate("Waschbärs");
            

            foreach (Gehege g in wildPark.Gehege)
            {
                Console.WriteLine(wildPark.Gehege);
            }
                
                    
        //            //Gehege alpenwiese = new Gehege("Alpenwiese");
        //    //Gehege ried = new Gehege("Ried");
        //    //Gehege alpen = new Gehege("Alpen");
        //    //Gehege wald = new Gehege("Wald");
        //    //Gehege katze = new Gehege("Katzen");
        //    //Gehege vogelkäfig = new Gehege("Vogelkäfig");


        //    Futter gras = new Futter("Gras", "kg", 0.23);
        //    Futter maus = new Futter("Maus", "Stück", 0.9);
        //    Futter alpenkräuter = new Futter("Alpenkräuter", "kg", 0.35);
        //    Futter fleisch = new Futter ("Fleisch", "kg", 3.60);
        //    Futter körner = new Futter("Körner", "Tassen", 0.10);

        //    //List<Tier> tiere = new List<Tier>();
        //    //{
        //    //    new Tier("Rijska", "Esel", gras, 37);
        //    //    new Tier("Agata", "Esel", gras, 35);
        //    //    new Tier("Cleo", "Zwergziege", gras, 15);
        //    //    new Tier("Misty", "Zwergziege", gras, 15);
        //    //    new Tier("Micha", "Zwergziege", gras, 11);
        //    //    new Tier("Heidi", "Kuh", gras, 40);
        //    //    new Tier("Bella", "Kuh", gras, 40);
        //    //    new Tier("Fiona", "Kuh", gras, 40);
        //    //    new Tier("Garmond", "Storch", maus, 10);
        //    //    new Tier("Hugo", "Storch", maus, 15);
        //    //    new Tier("Idaxis", "Storch", maus, 5);
        //    //    new Tier("Joris", "Steinbock", alpenkräuter, 40);
        //    //    new Tier("Miron", "Steinbock", alpenkräuter, 40);
        //    //    new Tier("Elwin", "Steinbock", alpenkräuter, 40);
        //    //    new Tier("Eduard", "Steinbock", alpenkräuter, 40);
        //    //    new Tier("Andreas", "Steinbock", alpenkräuter, 40);
        //    //    new Tier("Fenris", "Wolf", fleisch, 15);
        //    //    new Tier("Geri", "Wolf", fleisch, 13);
        //    //    new Tier("Freki", "Wolf", fleisch, 15);
        //    //    new Tier("Akay", "Wolf", fleisch, 22);
        //    //    new Tier("Maya", "Wolf", fleisch, 11);
        //    //    new Tier("Freddi", "Wildkatze", maus, 25);
        //    //    new Tier("Sam", "Wildkatze", maus, 21);
        //    //    new Tier("Scotty", "Wildkatze", maus, 27);
        //    //    new Tier("Luca", "Luchs", fleisch, 10);
        //    //    new Tier("Yukiko", "Luchs", fleisch, 9);
        //    //    new Tier("Rufus", "Luchs", fleisch, 5);
        //    //    new Tier("Tick", "Auerhuhn", körner, 4);
        //    //    new Tier("Trick", "Auerhuhn", körner, 5);
        //    //    new Tier("Track", "Auerhuhn", körner, 4);
        //    //    new Tier("Uhu-Stick", "Uhu", maus, 5);
        //    //    new Tier("Tixo", "Uhu", maus, 5);
        //    //}

        //    Tier rijska = new Tier("Rijska", "Esel", gras, 37);
        //    Tier agata = new Tier("Agata", "Esel", gras, 35);
        //    Tier cleo = new Tier("Cleo", "Zwergziege", gras, 15);
        //    Tier misty = new Tier("Misty", "Zwergziege", gras, 15);
        //    Tier micha = new Tier("Micha", "Zwergziege", gras, 11);
        //    Tier heidi = new Tier("Heidi", "Kuh", gras, 40);
        //    Tier bella = new Tier("Bella", "Kuh", gras, 40);
        //    Tier fiona = new Tier("Fiona", "Kuh", gras, 40);
        //    Tier garmond = new Tier("Garmond", "Storch", maus, 10);
        //    Tier hugo = new Tier("Hugo", "Storch", maus, 15);
        //    Tier idaxis = new Tier("Idaxis", "Storch", maus, 5);
        //    Tier joris = new Tier("Joris", "Steinbock", alpenkräuter, 40);
        //    Tier miron = new Tier("Miron", "Steinbock", alpenkräuter, 40);
        //    Tier elwin = new Tier("Elwin", "Steinbock", alpenkräuter, 40);
        //    Tier eduard = new Tier("Eduard", "Steinbock", alpenkräuter, 40);
        //    Tier andreas = new Tier("Andreas", "Steinbock", alpenkräuter, 40);
        //    Tier fenris = new Tier("Fenris", "Wolf", fleisch, 15);
        //    Tier geri = new Tier("Geri", "Wolf", fleisch, 13);
        //    Tier freki = new Tier("Freki", "Wolf", fleisch, 15);
        //    Tier akay = new Tier("Akay", "Wolf", fleisch, 22);
        //    Tier maya = new Tier("Maya", "Wolf", fleisch, 11);
        //    Tier freddi = new Tier("Freddi", "Wildkatze", maus, 25);
        //    Tier sam = new Tier("Sam", "Wildkatze", maus, 21);
        //    Tier scotty = new Tier("Scotty", "Wildkatze", maus, 27);
        //    Tier luca = new Tier("Luca", "Luchs", fleisch, 10);
        //    Tier yukiko = new Tier("Yukiko", "Luchs", fleisch, 9);
        //    Tier rufus = new Tier("Rufus", "Luchs", fleisch, 5);
        //    Tier tick = new Tier("Tick", "Auerhuhn", körner, 4);
        //    Tier trick = new Tier("Trick", "Auerhuhn", körner, 5);
        //    Tier track = new Tier("Track", "Auerhuhn", körner, 4);
        //    Tier uhustick = new Tier("Uhu-Stick", "Uhu", maus, 5);
        //    Tier tixo = new Tier("Tixo", "Uhu", maus, 5);


        //    Tierpfleger günther = new Tierpfleger("Günther", new List<Gehege> { alpenwiese, vogelkäfig, ried });
        //    Tierpfleger franz = new Tierpfleger("Franz", new List<Gehege> { ried, alpen });
        //    Tierpfleger felix = new Tierpfleger("Felix", new List<Gehege> { katze, wald, vogelkäfig});
        //    Tierpfleger jurgen = new Tierpfleger("Jürgen", new List<Gehege> {alpenwiese });


        //    //foreach (Tier tier in tiere)
        //    //{
        //    //    tier.FoodList.Add(tier.Food);
        //    //}






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


        //    //wildPark.Gehege.Add(alpenwiese);
        //    //wildPark.Gehege.Add(ried);
        //    //wildPark.Gehege.Add(alpen);
        //    //wildPark.Gehege.Add(wald);
        //    //wildPark.Gehege.Add(katze);
        //    //wildPark.Gehege.Add(vogelkäfig);


        //    ////schonbrunn.Gehege.Add(alpenwiese);
        //    ////schonbrunn.Tierpfleger.Add(jurgen);

        //    wildPark.Tierpfleger.Add(günther);
        //    wildPark.Tierpfleger.Add(franz);
        //    wildPark.Tierpfleger.Add(felix);


        //    alpenwiese.Tier.Add(rijska);
        //    alpenwiese.Tier.Add(agata);
        //    alpenwiese.Tier.Add(cleo);
        //    alpenwiese.Tier.Add(misty);
        //    alpenwiese.Tier.Add(micha);
        //    alpenwiese.Tier.Add(heidi);
        //    alpenwiese.Tier.Add(bella);
        //    alpenwiese.Tier.Add(fiona);
        //    ried.Tier.Add(garmond);
        //    ried.Tier.Add(hugo);
        //    ried.Tier.Add(idaxis);
        //    alpen.Tier.Add(joris);
        //    alpen.Tier.Add(miron);
        //    alpen.Tier.Add(elwin);
        //    alpen.Tier.Add(eduard);
        //    alpen.Tier.Add(andreas);
        //    wald.Tier.Add(fenris);
        //    wald.Tier.Add(geri);
        //    wald.Tier.Add(freki);
        //    wald.Tier.Add(akay);
        //    wald.Tier.Add(maya);
        //    katze.Tier.Add(freddi);
        //    katze.Tier.Add(sam);
        //    katze.Tier.Add(scotty);
        //    katze.Tier.Add(luca);
        //    katze.Tier.Add(yukiko);
        //    katze.Tier.Add(rufus);
        //    vogelkäfig.Tier.Add(tick);
        //    vogelkäfig.Tier.Add(trick);
        //    vogelkäfig.Tier.Add(track);
        //    vogelkäfig.Tier.Add(uhustick);
        //    vogelkäfig.Tier.Add(tixo);

        

        //    wildPark.PrintZoo();
        //    Console.WriteLine();
        //    wildPark.PrintZooStatistic();
        //    Console.WriteLine();
        //    günther.Füttern();
        //    franz.Füttern();
        //    felix.Füttern();

        //    ////schonbrunn.PrintZoo();
        }
    }
}
