

namespace Patrick.Week08.Museum
{
    public class MuseumMain
    {
        public static void Start()
        {
            Museum museum = new("Pinakothek", new DateTime(2023, 11, 21, 9, 0, 0), new DateTime(2023, 11, 21, 17, 0, 0));

            MainHallway mainHallway = new("Mainhallway");

            Hallway hallway1 = new("Hallway1");
            Hallway hallway2 = new("Hallway2");

            ExhibitionRoom room1 = new("room1");
            ExhibitionRoom room2 = new("room2");
            ExhibitionRoom room3 = new("room3");
            ExhibitionRoom room4 = new("room4");
            ExhibitionRoom room5 = new("room5");
            ExhibitionRoom room6 = new("room6");
            ExhibitionRoom room7 = new("room7");
            ExhibitionRoom room8 = new("room8");
            ExhibitionRoom room9 = new("room9");

            Artwork artwork1 = new("Monalisa");
            //Artwork artwork2 = new("Bildmitoelbeschuettet");
            //Artwork artwork3 = new("Staub");
            //Artwork artwork5 = new("Sun");
            //Artwork artwork6 = new("Bild2");
            //Artwork artwork7 = new("Bild3");
            //Artwork artwork8 = new("Bild4");
            //Artwork artwork9 = new("Bild5");



            mainHallway.AddRoom(room5);
            mainHallway.AddRoom(room9);
            mainHallway.AddRoom(hallway1);

            hallway1.AddRoom(room3);
            hallway1.AddRoom(hallway2);
            hallway1.AddRoom(mainHallway);

            hallway2.AddRoom(room1);
            hallway2.AddRoom(room6);           
            hallway2.AddRoom(hallway1);

            room1.AddRoom(hallway2);
            room1.AddRoom(room2);
            room1.AddArtwork(artwork1);

            room2.AddRoom(room1);
            room2.AddRoom(room3);

            room3.AddRoom(hallway1);
            room3.AddRoom(room2);
            room3.AddRoom(room4);
            room3.AddArtwork(artwork1);

            room4.AddRoom(room3);
            room4.AddRoom(room5);
            room4.AddArtwork(artwork1);

            room5.AddRoom(mainHallway);
            room5.AddRoom(room4);
            room5.AddArtwork(artwork1);

            room6.AddRoom(hallway2);
            room6.AddRoom(room7);
            room6.AddArtwork(artwork1);

            room7.AddRoom(room6);
            room7.AddRoom(room8);
            room7.AddArtwork(artwork1);

            room8.AddRoom(room7);
            room8.AddArtwork(artwork1);

            room9.AddRoom(mainHallway);
            room9.AddArtwork(artwork1);



            //Guardian g1 = new("Fred");

            Visitor v1 = new("Sandro");
            Visitor v2 = new("Timo");
            Visitor v3 = new("David");
            Visitor v4 = new("Fabian");

            Thief t1 = new("Chris");

        }

    }
}
