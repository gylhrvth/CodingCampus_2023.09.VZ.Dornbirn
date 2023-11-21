
namespace Fabian.Week08._05_Museum
{
    public class MuseumMain
    {
        public static void Start()
        {
            Museum museum = new("Pinakothek", new DateTime(2023, 11, 21, 9, 0, 0), new DateTime(2023, 11, 21, 17, 0, 0));

            MainHallway mainHallway = new("Mainhallway");

            Hallway hallway1 = new("hallway1");
            Hallway hallway2 = new("hallway2");

            ExhibitionRoom room1 = new("room1");
            ExhibitionRoom room2 = new("room2");
            ExhibitionRoom room3 = new("room3");
            ExhibitionRoom room4 = new("room4");
            ExhibitionRoom room5 = new("room5");
            ExhibitionRoom room6 = new("room6");
            ExhibitionRoom room7 = new("room7");
            ExhibitionRoom room8 = new("room8");
            ExhibitionRoom room9 = new("room9");

            Guardian g1 = new("Fred", 10);

            Thief t1 = new("Chris", 15, 50);

            mainHallway.Visitors.AddRange(new List<Visitor>
            {
                new("Sandro"),
                new("Timo"),
                new("David"),
                new("Fabian"),
                new("Patrick"),
                new("Cemal"),
                new("Dario"),
                new("Hassan"),
                new("Mohammed"),
            });

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


            museum.Hallways.Add(hallway1);
            museum.Hallways.Add(hallway2);

            museum.ExhibitionRooms.Add(room1);
            museum.ExhibitionRooms.Add(room2);
            museum.ExhibitionRooms.Add(room3);
            museum.ExhibitionRooms.Add(room4);
            museum.ExhibitionRooms.Add(room5);
            museum.ExhibitionRooms.Add(room6);
            museum.ExhibitionRooms.Add(room7);
            museum.ExhibitionRooms.Add(room8);
            museum.ExhibitionRooms.Add(room9);

            mainHallway.Neighbours.Add(room5);
            mainHallway.Neighbours.Add(room9);
            mainHallway.Neighbours.Add(hallway1);

            hallway1.Neighbours.Add(room3);
            hallway1.Neighbours.Add(hallway2);
            hallway1.Neighbours.Add(mainHallway);

            hallway2.Neighbours.Add(room1);
            hallway2.Neighbours.Add(room6);
            hallway2.Neighbours.Add(hallway1);

            room1.Neighbours.Add(hallway2);
            room1.Neighbours.Add(room2);

            room2.Neighbours.Add(room1);
            room2.Neighbours.Add(room3);

            room3.Neighbours.Add(hallway1);
            room3.Neighbours.Add(room2);
            room3.Neighbours.Add(room4);

            room4.Neighbours.Add(room3);
            room4.Neighbours.Add(room5);
            
            room5.Neighbours.Add(mainHallway);
            room5.Neighbours.Add(room4);

            room6.Neighbours.Add(hallway1);
            room6.Neighbours.Add(room7);

            room7.Neighbours.Add(room6);
            room7.Neighbours.Add(room8);

            room8.Neighbours.Add(room7);

            room9.Neighbours.Add(mainHallway);

            mainHallway.SendVistorsToRooms();

        }
    }
}
