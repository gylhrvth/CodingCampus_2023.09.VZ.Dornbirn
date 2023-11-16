using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            Console.OutputEncoding = Encoding.UTF8; //macht emojis windows + .

            Zoo zoo = new Zoo("Dream smp", 1970);

            Food cig = new Food("Cigarette🚬", "Pcs", 12.05, 7.00);
            Food salmon = new Food("Salmon🐟", "kg", 2.95, 13.99);
            Food nukes = new Food("Nukes☢️", "mg", 0.05, 900000000.000);
            Food beans = new Food("Beans🫘", "kg", 12.05, 3.99);
            Food child = new Food("Child🧒", "MT", 12500, 80000.00);
            Food mushrooms = new Food("Mushrooms🍄", "kg", 1.00, 7.79);
            Food dog = new Food ("Dog🐕", "MT", 12.09, 1999.99);
            Food whopper = new Food("Whopper", "kg", 88.00, 5.99);
            Food skittles = new Food("Skittles🌈", "kg", 0.90, 2.49);
            Food cheese = new Food("Cheese🧀", "kg", 1.00, 4.99);
            Food frosting = new Food("Frosting", "Can", 1, 2.80);
            Food sushi = new Food("Sushi🍣", "kg", 0.60, 12.00);
            Food que = new Food("Quesadilla🌮", "kg", 0.40, 6.85);
            Food tubur = new Food("Tubburger🍔", "kg", 0.50, 4.99);
            Food wiburg = new Food("Wilburger🍔", "kg", 0.50, 4.99);
            Food coca = new Food("Coca-Cola🥤", "l", 250.00, 1.45);
            Food soup = new Food("Miso-Soup🥣", "l", 700.00, 7.44);
            Food whiskey = new Food("Whiskey🍾", "l", 500.00, 19.90);
            Food wine = new Food("Wine🍷", "ml", 900.00, 23.99);
            Food cake = new Food("Cake🎂", "kg", 1.00, 7.22);
            Food spag = new Food("Spaghetti🍝", "kg", 150.00, 4.99);
            Food chicken = new Food("Chicken🍗", "kg", 1.00, 5.88);
            Food whale = new Food("Whale🐋", "kg", 250, 100.00);
            Food nsoup = new Food("Noodle-Soup🍜", "l", 700.00, 9.99);
            Food rice = new Food("Rice and veggies🍚", "kg", 2.00, 3.65);
            Food hot = new Food("Hotpockets🌯", "kg", 328.00, 4.99);
            Food blue = new Food("Blue💙", "?", 0.00, 0.00);

            Enclosure lasnevadas = new Enclosure("Las Nevadas🌃", "Subtropical", "hot");
            Enclosure snowchester = new Enclosure("Snowchester❄️", "Polar", "cold");
            Enclosure lmanburg = new Enclosure("L'Manburg💥", "Temperate", "medium");
            Enclosure kinokokingdom = new Enclosure("Kinoko Kingdom🍄", "Tropical", "warm");
            Enclosure eggpire = new Enclosure("Eggpire🩸", "Tropical", "warm");
            Enclosure gsmp = new Enclosure("The Greater SMP🏹", "Temperate", "medium");
            Enclosure manifold = new Enclosure("Manifoldland🟥🟦", "Temperate", "medium");
            Enclosure syndicate = new Enclosure("The Syndicate\U0001fa78", "Polar", "cold");
            Enclosure prison = new Enclosure("Pandoras Vault☢️", "-", "-");
            Enclosure ponks = new Enclosure("Ponk's Lemon City🍋", "Temperate", "medium");
            Enclosure boomer = new Enclosure("Boomerville🐸", "Tropical", "warm");
            Enclosure erets = new Enclosure("Eret's Castle👑", "Temperate", "medium");
            Enclosure cemetary = new Enclosure("Limbo💀", "-", "-");
       
            Animal quackity = new Animal("Quackity🦆", "Male", "Duckling-Hybrid", whiskey, 15);
            Animal slimecicle = new Animal("Slimecicle🟢", "Unknown", "Slime", child, 1);
            Animal foolish = new Animal("Foolish🦈", "Male","Totem-Shark-Hybrid", whale, 3);
            Animal niki = new Animal("Niki Nihachu", "Female","Human", cake, 2);
            Animal george = new Animal("GeorgeNotFound💤", "Male","Fae", mushrooms, 600);
            Animal sapnap = new Animal("Sapnap🔥", "Male","Blaze-Hybrid", sushi, 12);
            Animal karl = new Animal("Karl Jacobs🌀", "Genderfluid","Human?", skittles, 37);
            Animal tina = new Animal("TinaKitten🥕", "Female","Rabbit-Hybrid", soup, 4);
            Animal toms = new Animal("Tommyinnit🦝", "Male","Raccoon-Hybrid", coca, 69);
            Animal wil = new Animal("Wilbur Soot🚬", "Male","Undead?", cig, 48);
            Animal fundy = new Animal("Fundy🦊", "Male","Fox", salmon, 2);
            Animal tubbo = new Animal("Tubbo Underscore☢️", "Non-Binary", "Ram-Hybrid",nukes, 3);
            Animal ran = new Animal("Ghostboo👻","Non-Binary","Ghost",frosting, 5);
            Animal micheal = new Animal("Micheal", "Unknown","Piglin", tubur, 1);
            Animal aimsey = new Animal ("Aimsey", "Genderfluid","Bunny-Hybrid", rice, 1);
            Animal skeppy = new Animal("Skeppy💎", "Unknown","Diamond",hot, 4);
            Animal badbh = new Animal("BadBoyHalo", "Unknown","Demon", cheese, 3);
            Animal hannah = new Animal("Hannah Rose🌹", "Female","Rose-Nymph", wine, 8);
            Animal antfrost = new Animal("Antfrost😺", "Male","Cat", dog, 7);
            Animal dream = new Animal("Dream🟩", "Agender","Nymph-Hybrid", child, 1);
            Animal cpk = new Animal("Seepeekay", "Male","Human", soup, 6);
            Animal jack = new Animal("Jack Manifold🟦🟥", "what","Human", whopper, 1);
            Animal tech = new Animal("Technoblade⚔️", "Agender","Piglin-Hybrid", cake, 1);
            Animal phil = new Animal("Philza Minecraft🪽", "Male", "Elytrian.Hybrid",chicken, 2);
            Animal mumza = new Animal("Kristen☠️", "Female","Death", spag, 2);
            Animal sam = new Animal ("AweSamDude☢️", "Agender","Creeper-Hybrid", nukes, 1);
            Animal ponk = new Animal("Ponk", "Genderfluid", "Human",nsoup, 2);
            Animal eret = new Animal("Eret👑", "Genderfluid", "Whither-Hybrid",rice, 5);
            Animal boomers = new Animal("Boomer", "Male","Human", beans, 1);
            Animal boo = new Animal("Ranboo🟥🟩", "Non-Binary","Enderman", wiburg, 1);
            Animal gboo = new Animal("Ghostbur🔵", "Agender","Ghost", blue, 1);
            Animal js = new Animal("JSchlatt🍺", "Male","Ram-Hybrid", whiskey, 77);
            Animal md = new Animal("Mexican Dream🌮", "whut","MEXICAN", que, 34);
           
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
            
            zoo.PrintStructure();
            Console.WriteLine();
            zoo.PrintFoodReport();
        }
    }
}