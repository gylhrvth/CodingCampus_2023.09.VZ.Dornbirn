namespace Selina.Week06.Zoo
{
    public class MainZoo
    {
        public static void Start()
        {
            Dictionary<int, int> foodPrice = new Dictionary<int, int>();

            Zoo zoo = new Zoo("Selina's Zoo", "Hohenems", 2023, 53);

            Food banana = new Food("Banane", "bunch", 5);
            Food salad = new Food("Salat", "pieces", 3);
            Food hay = new Food("Heu", "piece", 30);
            Food meet = new Food("Fleisch", "pieces", 100);

            Gehege rainforest = new Gehege("Regenwald", "Outdoor and Indoor", "warm");
            Gehege stoneLandscape = new Gehege("Steinlandschaft", "Outdoor and Indoor", "warm 18-25°");
            Gehege barn = new Gehege("Stall", "Outdoor and Indoor", "10-20°");
            Gehege woods = new Gehege("Wald", "Outdoor", "cold");

            Animals monkey1 = new Animals("Fluffy", 10, "weiblich", banana, 10);
            Animals tortoise1 = new Animals("Speed", 70, "männlich", salad, 3);
            Animals goat1 = new Animals("Chaely", 3, "weiblich", hay, 5);
            Animals wolf1 = new Animals("Hazel", 7, "männlich", meet, 5);
            Animals monkey2 = new Animals("Lucy", 4, "weiblich", banana, 5);
            Animals tortoise2 = new Animals("Stella", 50, "weiblich", salad, 3);
            Animals goat2 = new Animals("Simba", 5, "männlich", hay, 4);
            Animals wolf2 = new Animals("Archie", 4, "männlich", meet, 6);

            Nurse alex = new Nurse("Alex", 34, "männlich");
            Nurse sandra = new Nurse("Sandra", 44, "weiblich");
            Nurse michael = new Nurse("Michael", 49, "männlich");
            Nurse selina = new Nurse("Selina", 18, "weiblich");

            zoo.AddGehege(rainforest);
            zoo.AddGehege(stoneLandscape);
            zoo.AddGehege(barn);
            zoo.AddGehege(woods);

            rainforest.AddAnimals(monkey1);
            rainforest.AddAnimals(monkey2);
            stoneLandscape.AddAnimals(tortoise1);
            stoneLandscape.AddAnimals(tortoise2);
            barn.AddAnimals(goat1);
            barn.AddAnimals(goat2);
            woods.AddAnimals(wolf1);
            woods.AddAnimals(wolf2);

            rainforest.AddNurse(alex);
            stoneLandscape.AddNurse(sandra);
            barn.AddNurse(michael);
            woods.AddNurse(selina);


            zoo.PrintZoo();

            double totalprice = zoo.CalculateFoodPrice();
            Console.WriteLine($"\nDie Tageskosten für den Zoo betragen: {totalprice}");
        }
    }
}
