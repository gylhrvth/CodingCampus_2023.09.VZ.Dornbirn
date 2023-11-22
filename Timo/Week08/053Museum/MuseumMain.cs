﻿
namespace Timo.Week08._053Museum
{
    public class MuseumMain
    {
        public static void Start()
        {

            Hallway mainHallway = new("main hallway");

            Museum museum = new("Pinakothek", mainHallway);

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

            Visitor sandro = new("Sandro");
            Visitor timo = new("Timo");
            Visitor david = new("David");
            Visitor fabian = new("Fabian");
            Visitor patrick = new("Patrick");
            Visitor cemal = new("Cemal");
            Visitor dario = new("Dario");
            Visitor hassan = new("Hassan");
            Visitor mohammed = new("Mohammed");            

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

            mainHallway.AddNeighour(room5);
            mainHallway.AddNeighour(room9);
            mainHallway.AddNeighour(hallway1);

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

            //Simulation

            museum.PrintStructure("");

            museum.AddVisitor(sandro);
            museum.AddVisitor(timo);
            museum.AddVisitor(david);
            museum.AddVisitor(fabian);
            museum.AddVisitor(patrick);
            museum.AddVisitor(cemal);
            museum.AddVisitor(dario);
            museum.AddVisitor(hassan);
            museum.AddVisitor(mohammed);




        }
    }
}
