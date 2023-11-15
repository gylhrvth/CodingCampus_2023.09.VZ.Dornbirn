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

            Enclosure lasnevadas = new Enclosure("Las Nevadas", "Subtropical", "hot");
            Enclosure snowchester = new Enclosure("Snow Chester", "Polar", "cold");
            Enclosure lmanburg = new Enclosure("L'Manburg", "Temperate", "medium");
            Enclosure kinokokingdom = new Enclosure("Kinoko Kingdom", "Tropical", "warm");
            Enclosure eggpire = new Enclosure("Eggpire", "Tropical", "warm");
            Enclosure gsmp = new Enclosure("Greater SMP", "Temperate", "medium");
            Enclosure manifold = new Enclosure("Manifoldland", "Temperate", "medium");
            Enclosure syndicate = new Enclosure("The Syndicate", "Polar", "cold");
            Enclosure prison = new Enclosure("Pandoras Vault", "-", "-");
            Enclosure ponks = new Enclosure("Ponk's Lemon City", "Temperate", "medium");
            Enclosure boomer = new Enclosure("Boomerville", "Tropical", "warm");
            Enclosure erets = new Enclosure("Eret's Castle", "Temperate", "medium");

            Food mushrooms = new Food("Mushrooms", "Handful", 10);
            Food whiskey = new Food("Whiskey", "Bottle", 40);
            Food salmon = new Food("Salmon", "Pound", 28);
            Food cig = new Food("Cigarette", "Pack", 7);
            Food cake = new Food("Cake", "Piece", 4);
            Food wine = new Food("Wine", "Bottle", 20);
            Food chicken = new Food("Chicken", "Wing", 1);
            Food child = new Food("Child", "50kg", 10000);
            Food spag = new Food("Spaghetti", "Plate", 20);
            Food soup = new Food("Miso-Soup", "Bowl", 10);
            Food nukes = new Food("Nuke", "City", 420);
            Food dog = new Food("Dog", "Puppy", 60);
            Food whale = new Food("Whaleflesh", "Half Whale", 70);
            Food skittles = new Food("Skittles", "Pack", 2);
            Food ramen = new Food("Ramen", "Bowl", 15);
            Food coke = new Food("Coca Cola", "Bottle", 2);
            Food beans = new Food("Beans", "Can", 3);

            Animals quackity = new Animals("Quackity", "Male", whiskey, 15);
            Animals slimecicle = new Animals("Slimecicle", "Unknown", child, 1);
            Animals foolish = new Animals("Foolish", "Male",soup, 3);
            Animals niki = new Animals("Niki Nihachu", "Female", cake, 2);
            Animals george = new Animals("GeorgeNotFound", "Male", mushrooms, 600);
            Animals sapnap = new Animals("Sapnap", "Male", dog, 1);
            Animals karl = new Animals("Karl Jacobs", "Genderfluid", skittles, 37);
            Animals tina = new Animals("TinaKitten", "Female", chicken, 1);
            Animals toms = new Animals("Tommyinnit", "Male", coke, 69);
            Animals wil = new Animals("Wilbur Soot", "Male", cig,48);
            Animals fundy = new Animals("Fundy", "Male", salmon, 2);
            Animals tubbo = new Animals("Tubbo Underscore", "Non-Binary", nukes, 3);
            Animals ran = new Animals("Ranboo","Non-Binary",beans, 5);
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

            zoo.addEnclosure(lasnevadas);
            zoo.addEnclosure(snowchester);
            zoo.addEnclosure(lmanburg);
            zoo.addEnclosure(kinokokingdom);
            zoo.addEnclosure(gsmp);
            zoo.addEnclosure(manifold);
            zoo.addEnclosure(syndicate);
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

            zoo.PrintStructure();   
        }
    }
}