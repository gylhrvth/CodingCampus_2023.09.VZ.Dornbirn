
namespace Fabian.Week08._05_Museum
{
    public class MuseumMain
    {
        public static void Start()
        {
            Museum museum = new("Pinakothek", new DateTime(2023, 11, 21, 9, 0, 0), new DateTime(2023, 11, 21, 17, 0, 0));

            MainHallway main = new("Mainhallway");

            Hallway hallway1 = new("Hallway1");
            Hallway hallway2 = new("Hallway2");

            ExhibitiomRoom room1 = new("room1");
            ExhibitiomRoom room2 = new("room2");
            ExhibitiomRoom room3 = new("room3");
            ExhibitiomRoom room4 = new("room4");

            Guardian g1 = new("Fred", 10);

            Visitor v1 = new("Sandro");
            Visitor v2 = new("Timo");
            Visitor v3 = new("David");
            Visitor v4 = new("Fabian");

            Thief t1 = new("Chris", 15, 50);

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


            museum.Hallways.Add(hallway1);
            museum.Hallways.Add(hallway2);

            museum.ExhibitionRooms.Add(room1);
            museum.ExhibitionRooms.Add(room2);
            museum.ExhibitionRooms.Add(room3);
            museum.ExhibitionRooms.Add(room4);


        }
    }
}
