using static Fabian.Selftest_SP.TowersOfHanoi;
namespace Fabian.Week08._05_Museum
{
    public class MuseumMain
    {
        public static void Start()
        {

            Hallway mainHallway = new("main hallway", 1);

            Museum museum = new("Pinakothek", mainHallway);

            Hallway hallway1 = new("hallway 1", 2);
            Hallway hallway2 = new("hallway 2", 3);

            ExhibitionRoom room1 = new("room 1", 4);
            ExhibitionRoom room2 = new("room 2", 4);
            ExhibitionRoom room3 = new("room 3", 3);
            ExhibitionRoom room4 = new("room 4", 3);
            ExhibitionRoom room5 = new("room 5", 2);
            ExhibitionRoom room6 = new("room 6", 4);
            ExhibitionRoom room7 = new("room 7", 5);
            ExhibitionRoom room8 = new("room 8", 6);
            ExhibitionRoom room9 = new("room 9", 2);

            Guardian g1 = new("Fred", 10);

            Thief t1 = new("mr nonsuspect", 15, 3);
            Thief t2 = new("Hassan", 20, 3);
            Thief t3 = new("mr suspect", 30, 3);

            Visitor sandro = new("Sandro");
            Visitor timo = new("Timo");
            Visitor david = new("David");
            Visitor fabian = new("Fabian");
            Visitor patrick = new("Patrick");
            Visitor cemal = new("Cemal");
            Visitor dario = new("Dario");
            Visitor kuhl = new("Kuhl");
            Visitor mohammed = new("Mohammed");            
            Visitor guenther = new("Günther");            
            Visitor fred = new("Fred");            
            Visitor olaf = new("Olaf");            
            Visitor bro = new("Bro");            
            Visitor hugo = new("Hugo");            
            Visitor garmond = new("Garmond");            
            Visitor idaxis = new("Idaxis");            
            Visitor fenris = new("Fenris");            
            Visitor heinrich = new("Heinrich");            
            Visitor doris = new("Doris");            
            Visitor yukiko = new("Yukiko");            

            room1.Artworks.AddRange(new List<Artwork>()
            {
                new("Mona Lisa", 5),
                new("Girl with a Pearl Earring", 10),
                new("The Starry Night", 8),
                new("The Kiss", 3),
            });
            room2.Artworks.AddRange(new List<Artwork>()
            {
                new("The Birth of Venus", 5),
                new("Arrangement in Grey and Black", 10),
                new("The Arnolfini Portrait", 8),
                new("The Garden of Earthly Delights", 3),
            });

            room3.Artworks.AddRange(new List<Artwork>()
            {
                new("Composition with Red Blue and Yellow", 5),
                new("Las Meninas", 10),
                new("Guernica", 8),
                new("The Naked Maja", 3),
            });

            room4.Artworks.AddRange(new List<Artwork>()
            {
                new("A Sunday Afternoon on the Island of La Grande Jatte", 5),
                new("Les Demoiselles d’Avignon", 10),
                new("The Harvesters", 8),
                new("Le Déjeuner sur l’herbe", 3),
            });

            room5.Artworks.AddRange(new List<Artwork>()
            {
                new("Grande Odalisque", 5),
                new("Liberty Leading the People", 10),
                new("Sunrise", 8),
                new("Wanderer above the Sea of Fog", 3),
            });

            room6.Artworks.AddRange(new List<Artwork>()
            {
                new("The Raft of the Medusa", 5),
                new("Nighthawks", 10),
                new("Nude Descending a Staircase", 8),
                new("American Gothic", 3),
            });

            room7.Artworks.AddRange(new List<Artwork>()
            {
                new("The Night Watch", 5),
                new("Café Terrace at Night", 10),
                new("Whistler's Mother", 8),
                new("The Sleeping Gypsy", 3),
            });

            room8.Artworks.AddRange(new List<Artwork>()
            {
                new("Bal du moulin de la Galette", 5),
                new("Les Demoiselles d’Avignon", 10),
                new("Impression, Sunrise", 8),
                new("The Third of May 1808", 3),
            });

            room9.Artworks.AddRange(new List<Artwork>()
            {
                new("Liberty Leading the People", 5),
                new("Le Déjeuner sur l’herbe", 10),
                new("Lady with an Ermine", 8),
                new("The Raft of the Medusa", 3),
            });


            Hallway exit = new("exit", 0);

            mainHallway.AddNeighour(room5);
            mainHallway.AddNeighour(room9);
            mainHallway.AddNeighour(hallway1);
            mainHallway.AddNeighour(exit);

            hallway1.AddNeighour(room3);
            hallway1.AddNeighour(hallway2);
            hallway1.AddNeighour(room6);

            hallway2.AddNeighour(room1);
            hallway2.AddNeighour(room6);

            room1.AddNeighour(room2);
            room2.AddNeighour(room3);
            room3.AddNeighour(room4);
            room4.AddNeighour(room5);
            room6.AddNeighour(room7);
            room7.AddNeighour(room8);

            museum.PrintStructure("");
            Console.WriteLine();

            museum.AddVisitor(sandro);
            museum.AddVisitor(timo);
            museum.AddVisitor(david);
            museum.AddVisitor(fabian);
            museum.AddVisitor(patrick);
            museum.AddVisitor(cemal);
            museum.AddVisitor(dario);
            museum.AddVisitor(kuhl);
            museum.AddVisitor(mohammed);
            museum.AddVisitor(guenther);
            museum.AddVisitor(fred);
            museum.AddVisitor(olaf);
            museum.AddVisitor(bro);
            museum.AddVisitor(garmond);
            museum.AddVisitor(hugo);
            museum.AddVisitor(idaxis);
            museum.AddVisitor(fenris);
            museum.AddVisitor(heinrich);
            museum.AddVisitor(doris);
            museum.AddVisitor(yukiko);
            museum.AddVisitor(t1);
            museum.AddVisitor(t2);
            museum.AddVisitor(t3);

            Console.WriteLine();

            for (int i = 0; i < 17; i++)
            {
                museum.Tick();
            }
            SetConsoleColor(ConsoleColor.DarkYellow, "The museum is closing, visitors must leave now!");
            for (int i = 0; i < 7; i++)
            {
                museum.LeaveMuseum();
            }



        }
    }
}
