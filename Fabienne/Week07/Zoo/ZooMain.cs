using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Fabienne.Week07.Zoo
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new Zoo("Dream smp", 1970);

            Food cig = new Food("Cigarette", "Pcs", 12.05);
            Food salmon = new Food("Salmon", "kg", 2.95);
            Food nukes = new Food("Nukes", "mg", 0.05);
            Food beans = new Food("Beans", "kg", 12.05);
            Food child = new Food("Child", "MT", 12500);
            Food 

            Enclosure lasnevadas = new Enclosure("Las Nevadas", "Subtropical", "hot");
            Enclosure snowchester = new Enclosure("Snowchester", "Polar", "cold");
            Enclosure lmanburg = new Enclosure("L'Manburg", "Temperate", "medium");
            Enclosure kinokokingdom = new Enclosure("Kinoko Kingdom", "Tropical", "warm");
            Enclosure eggpire = new Enclosure("Eggpire", "Tropical", "warm");
            Enclosure gsmp = new Enclosure("The Greater SMP", "Temperate", "medium");
            Enclosure manifold = new Enclosure("Manifoldland", "Temperate", "medium");
            Enclosure syndicate = new Enclosure("The Syndicate", "Polar", "cold");
            Enclosure prison = new Enclosure("Pandoras Vault", "-", "-");
            Enclosure ponks = new Enclosure("Ponk's Lemon City", "Temperate", "medium");
            Enclosure boomer = new Enclosure("Boomerville", "Tropical", "warm");
            Enclosure erets = new Enclosure("Eret's Castle", "Temperate", "medium");
            Enclosure cemetary = new Enclosure("Limbo", "-", "-");
       
            Animal quackity = new Animal("Quackity", "Male", cig, 15);
            Animal slimecicle = new Animal("Slimecicle", "Unknown", cig, 1);
            Animal foolish = new Animal("Foolish", "Male", beans, 3);
            Animal niki = new Animal("Niki Nihachu", "Female", beans, 2);
            Animal george = new Animal("GeorgeNotFound", "Male", child, 600);
            Animal sapnap = new Animal("Sapnap", "Male", nukes, 12);
            Animal karl = new Animal("Karl Jacobs", "Genderfluid", child, 37);
            /*
            Animals tina = new Animals("TinaKitten", "Female", 1, true);
            Animals toms = new Animals("Tommyinnit", "Male", 69, true);
            Animals wil = new Animals("Wilbur Soot", "Male", cig,48);
            Animals fundy = new Animals("Fundy", "Male", salmon, 2);
            Animals tubbo = new Animals("Tubbo Underscore", "Non-Binary", nukes, 3);
            Animals ran = new Animals("Ghostboo","Non-Binary",beans, 5);
            Animals micheal = new Animals("Micheal", "Unknown", salmon, 1);
            Animals aimsey = new Animals("Aimsey", "Genderfluid", whale, 1);
            Animals skeppy = new Animals("Skeppy", "Unknown",ramen, 4);
            Animals badbh = new Animals("BadBoyHalo", "Unknown", spag, 3);
            Animals hannah = new Animals("Hannah Rose", "Female",wine, 8);
            Animals antfrost = new Animals("Antfrost", "Male", dog, 7);
            Animals dream = new Animals("Dream", "Agender", child, 1);
            Animals cpk = new Animals("Seepeekay", "Male", soup, 6);
            Animals jack = new Animals("Jack Manifold", "what", skittles, 1);
            Animals tech = new Animals("Technoblade", "Agender", cake, 1);
            Animals phil = new Animals("Philza Minecraft", "Male", chicken, 2);
            Animals mumza = new Animals("Kristen", "Female", spag, 2);
            Animals sam = new Animals("AweSamDude", "Agender", nukes, 1);
            Animals ponk = new Animals("Ponk", "Genderfluid", ramen, 2);
            Animals eret = new Animals("Eret", "Genderfluid", mushrooms, 5);
            Animals boomers = new Animals("Boomer", "Male", coke, 1);
            Animals boo = new Animals("Ranboo", "Non-Binary", coke, 1);
            Animals gboo = new Animals("Ghostbur", "Agender", coke, 1);
            Animals js = new Animals("JSchlatt", "Male", whiskey, 77);
            Animals md = new Animals("Mexican Dream", "Mexican", en, 34);
            */

            zoo.addEnclosure(lasnevadas);
            zoo.addEnclosure(snowchester);
            zoo.addEnclosure(lmanburg);
            zoo.addEnclosure(kinokokingdom);
            zoo.addEnclosure(gsmp);
            zoo.addEnclosure(syndicate);
            zoo.addEnclosure(cemetary);
            zoo.addEnclosure(manifold);
            zoo.addEnclosure(ponks);
            zoo.addEnclosure(prison);
            zoo.addEnclosure(boomer);
            zoo.addEnclosure(erets);

            lasnevadas.AddAnimals(quackity);
            lasnevadas.AddAnimals(slimecicle);
            lasnevadas.AddAnimals(foolish);

            kinokokingdom.AddAnimals(niki);
            kinokokingdom.AddAnimals(george);
            kinokokingdom.AddAnimals(sapnap);
            kinokokingdom.AddAnimals(karl);
            /*
            kinokokingdom.AddAnimals(tina);

            lmanburg.AddAnimals(toms);
            lmanburg.AddAnimals(wil);
            lmanburg.AddAnimals(fundy);

            snowchester.AddAnimals(tubbo);
            snowchester.AddAnimals(ran);
            snowchester.AddAnimals(micheal);
            snowchester.AddAnimals(aimsey);

            eggpire.AddAnimals(badbh);
            eggpire.AddAnimals(skeppy);
            eggpire.AddAnimals(hannah);
            eggpire.AddAnimals(antfrost);

            gsmp.AddAnimals(dream);
            gsmp.AddAnimals(cpk);

            manifold.AddAnimals(jack);

            syndicate.AddAnimals(tech);
            syndicate.AddAnimals(phil);
            syndicate.AddAnimals(mumza);

            prison.AddAnimals(sam);

            ponks.AddAnimals(ponk);

            erets.AddAnimals(eret);

            boomer.AddAnimals(boomers);

            cemetary.AddAnimals(js);
            cemetary.AddAnimals(boo);
            cemetary.AddAnimals(gboo);
            cemetary.AddAnimals(md);
            */
            zoo.PrintStructure();
            zoo.PrintFoodReport();
        }
    }
}