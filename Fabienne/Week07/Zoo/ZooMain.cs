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
            Console.WriteLine("");
            Zoo zoo = new Zoo("Dream smp", 1970);

            Food cig = new Food("Cigarette🚬", "Pcs", 12.05);
            Food salmon = new Food("Salmon🐟", "kg", 2.95);
            Food nukes = new Food("Nukes☢️", "mg", 0.05);
            Food beans = new Food("Beans🫘", "kg", 12.05);
            Food child = new Food("Child🧒", "MT", 12500);
            Food mushrooms = new Food("Mushrooms🍄", "kg", 1.00);
            Food dog = new Food ("Dog🐕", "MT", 12.09);
            Food whopper = new Food("Whopper", "mg", 88.00);
            Food skittles = new Food("Skittles🌈", "kg", 0.90);
            Food cheese = new Food("Cheese🧀", "kg", 1.00);
            Food frosting = new Food("Frosting", "Can", 1);
            Food sushi = new Food("Sushi🍣", "kg", 0.60);
            Food que = new Food("Quesadilla🌮", "kg", 0.40);
            Food tubur = new Food("Tubburger🍔", "kg", 0.50);
            Food wiburg = new Food("Wilburger🍔", "kg", 0.50);
            Food coca = new Food("Coca-Cola🥤", "ml", 250.00);
            Food soup = new Food("Miso-Soup🥣", "ml", 700.00);
            Food whiskey = new Food("Whiskey🍾", "ml", 500.00);
            Food wine = new Food("Wine🍷", "ml", 900.00);
            Food cake = new Food("Cake🎂", "kg", 1.00);
            Food spag = new Food("Spaghetti🍝", "g", 150.00);
            Food chicken = new Food("Chicken🍗", "kg", 1.00);
            Food whale = new Food("Whale🐋", "kg", 250);
            Food nsoup = new Food("Noodle-Soup🍜", "ml", 700.00);
            Food rice = new Food("Rice and veggies🍚", "kg", 2.00);
            Food hot = new Food("Hotpockets🌯", "g", 328.00);
            Food blue = new Food("Blue💙", "?", 0.00);

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
       
            Animal quackity = new Animal("Quackity🦆", "Male", whiskey, 15);
            Animal slimecicle = new Animal("Slimecicle🟢", "Unknown", child, 1);
            Animal foolish = new Animal("Foolish🦈", "Male", whale, 3);
            Animal niki = new Animal("Niki Nihachu", "Female", cake, 2);
            Animal george = new Animal("GeorgeNotFound💤", "Male", mushrooms, 600);
            Animal sapnap = new Animal("Sapnap🔥", "Male", sushi, 12);
            Animal karl = new Animal("Karl Jacobs🌀", "Genderfluid", skittles, 37);
            Animal tina = new Animal("TinaKitten🥕", "Female", soup, 4);
            Animal toms = new Animal("Tommyinnit🦝", "Male", coca, 69);
            Animal wil = new Animal("Wilbur Soot🚬", "Male", cig, 48);
            Animal fundy = new Animal("Fundy🦊", "Male", salmon, 2);
            Animal tubbo = new Animal("Tubbo Underscore☢️", "Non-Binary", nukes, 3);
            Animal ran = new Animal("Ghostboo👻","Non-Binary",frosting, 5);
            Animal micheal = new Animal("Micheal", "Unknown", tubur, 1);
            Animal aimsey = new Animal ("Aimsey", "Genderfluid", rice, 1);
            Animal skeppy = new Animal("Skeppy💎", "Unknown",hot, 4);
            Animal badbh = new Animal("BadBoyHalo", "Unknown", cheese, 3);
            Animal hannah = new Animal("Hannah Rose🌹", "Female",wine, 8);
            Animal antfrost = new Animal("Antfrost😺", "Male", dog, 7);
            Animal dream = new Animal("Dream🟩", "Agender", child, 1);
            Animal cpk = new Animal("Seepeekay", "Male", soup, 6);
            Animal jack = new Animal("Jack Manifold🟦🟥", "what", whopper, 1);
            Animal tech = new Animal("Technoblade⚔️", "Agender", cake, 1);
            Animal phil = new Animal("Philza Minecraft🪽", "Male", chicken, 2);
            Animal mumza = new Animal("Kristen☠️", "Female", spag, 2);
            Animal sam = new Animal ("AweSamDude☢️", "Agender", nukes, 1);
            Animal ponk = new Animal("Ponk", "Genderfluid", nsoup, 2);
            Animal eret = new Animal("Eret👑", "Genderfluid", rice, 5);
            Animal boomers = new Animal("Boomer", "Male", beans, 1);
            Animal boo = new Animal("Ranboo🟥🟩", "Non-Binary", wiburg, 1);
            Animal gboo = new Animal("Ghostbur🔵", "Agender", blue, 1);
            Animal js = new Animal("JSchlatt🍺", "Male", whiskey, 77);
            Animal md = new Animal("Mexican Dream🌮", "Mexican", que, 34);
           
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