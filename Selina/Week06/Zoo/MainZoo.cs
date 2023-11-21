using System.Text;

namespace Selina.Week06.Zoo
{
    public class MainZoo
    {
        public static void Start()
        {
            double totalprice = 0;

            Console.OutputEncoding = Encoding.UTF8; //Emojis 

            Zoo zoo = new Zoo("Selina's Zoo👩‍🌾", "Hohenems", 2023, 53); //Zoo Name

            // Essen für die Tiere
            Food banana = new Food("Banane 🍌", "kg", 20);
            Food salad = new Food("Salat  🥗", "kg", 3);
            Food hay = new Food("Heu    🌾", "kg", 40);
            Food meet = new Food("Fleisch🥩", "kg", 100);

            //Gehgen für die Tiere
            Gehege rainforest = new Gehege("Regenwald🌧️", "Outdoor and Indoor", "warm");
            Gehege stoneLandscape = new Gehege("Steinlandschaft🪨", "Outdoor and Indoor", "warm 18-25°");
            Gehege barn = new Gehege("Stall🐐", "Outdoor and Indoor", "10-20°");
            Gehege woods = new Gehege("Wald🌳", "Outdoor", "cold");

            //Tiere die in den Gehegen wohnen
            Animal monkey1 = new Animal("Fluffy🐒", 10, "weiblich", banana, 8, true, 100, 300, 0);
            Animal tortoise1 = new Animal("Speed 🐢", 70, "männlich", salad, 3, true, 50, 200, 0);
            Animal goat1 = new Animal("Chaely🐐", 3, "weiblich", hay, 5, true, 80, 220, 0);
            Animal wolf1 = new Animal("Hazel 🐺", 7, "männlich", meet, 5, true, 300, 500, 0);
            Animal monkey2 = new Animal("Lucy  🐒", 4, "weiblich", banana, 5, true, 100, 300, 0);
            Animal tortoise2 = new Animal("Stella🐢", 50, "weiblich", salad, 3, true, 50, 200, 0);
            Animal goat2 = new Animal("Simba 🐐", 5, "männlich", hay, 4, true, 80, 220, 0);
            Animal wolf2 = new Animal("Archie🐺", 4, "männlich", meet, 16, true, 400, 600, 0);

            // Pfleger die auf die Tiere aufpassen und jedem Pfleger wird ein Gehege zugeteilt
            Nurse alex = new Nurse("Alex    🧔🏻", 34, "männlich", "Wolf🐺");
            Nurse sandra = new Nurse("Sandra 👩🏼‍🦰", 44, "weiblich", "Ziege🐐");
            Nurse michael = new Nurse("Michael 🧑🏼", 49, "männlich", "Schildkröte🐢");
            Nurse selina = new Nurse("Selina  👩🏼", 18, "weiblich", "Affe🐒");

            //Tierärzte, die auf die Tiere aufpassen
            Veterinarian manuel = new Veterinarian("Manuel 👨🏼‍⚕️", 25);
            Veterinarian janine = new Veterinarian("Janine 👩🏼‍⚕️", 28);

            //Tierärzte werden zur Liste _VeterinarianList in der Zoo Klasse hinzugefügt
            zoo.AddVeterinarian(manuel);
            zoo.AddVeterinarian(janine);

            // Gehegen werden zur Liste _GehegeList in der Zoo Klasse hinzugefügt
            zoo.AddGehege(rainforest);
            zoo.AddGehege(stoneLandscape);
            zoo.AddGehege(barn);
            zoo.AddGehege(woods);

            // Tiere werden zum Gehege mit einer Liste hinzugefügt 
            rainforest.AddAnimals(monkey1);
            rainforest.AddAnimals(monkey2);
            stoneLandscape.AddAnimals(tortoise1);
            stoneLandscape.AddAnimals(tortoise2);
            barn.AddAnimals(goat1);
            barn.AddAnimals(goat2);
            woods.AddAnimals(wolf1);
            woods.AddAnimals(wolf2);

            //Pfleger werden zu den Gehgen zugeteilt
            rainforest.AddNurse(alex);
            stoneLandscape.AddNurse(sandra);
            barn.AddNurse(michael);
            woods.AddNurse(selina);

            //Ausgabe für User
            zoo.PrintZoo();

            Console.WriteLine("\n------------------------------------------------------------------------------");

            //Essen wird für die Tiere wird berechnet und ausgeben
            Dictionary<Food, int> report = zoo.CalculateFoodPrice();
            Console.WriteLine($"Die Tageskosten für den Zoo betragen:\n");

            foreach (Food f in report.Keys)
            {
                totalprice += f.Price;
                Console.WriteLine($"{f.Name,-20} {report[f],5} {f.Unit,-5} {f.Price,4} Euro");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Gesamtpreis = {totalprice,23} Euro");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("------------------------------------------------------------------------------\n");

            //Tiere werden gefüttert
            rainforest.FeedAnimal();
            stoneLandscape.FeedAnimal();
            barn.FeedAnimal();
            woods.FeedAnimal();

            Console.WriteLine("------------------------------------------------------------------------------\n");

            //Tiere beißen sich untereinander
            rainforest.BiteAnimal();
            stoneLandscape.BiteAnimal();
            barn.BiteAnimal();
            woods.BiteAnimal();

            Console.WriteLine("------------------------------------------------------------------------------\n");

        }
    }
}
