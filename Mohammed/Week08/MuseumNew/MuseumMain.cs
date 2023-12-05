using System;
namespace Mohammed.Week08.MuseumNew
{
    public class MuseumMain
    {
        public static void Start()
        {
            HallwayMain hallMain = new HallwayMain("Haupteingang");
            Museum museum = new Museum("Pinakothek", hallMain);

            ExhibitionRoom room1 = new("BilderGalerie");
            ExhibitionRoom room2 = new("StatuenGalerie");
            ExhibitionRoom room3 = new("KunstaustellungsRaum");
            ExhibitionRoom room4 = new("DinosaurierRaum");
            ExhibitionRoom room5 = new("SteinzeitRaum");

            Hallway hall1 = new Hallway("Gang1");

            Person guest1 = new Person("Andreas");
            Person guest2 = new Person("Sabine");
            Person guest3 = new Person("Hannes");

            ArtWork monalisa = new("Monalisa");
            ArtWork derKuss = new("Der Kuss");
            ArtWork hassan = new("Hassan! :)");
            ArtWork skulptur = new("Statue von Caesar");
            ArtWork shark = new("Shark");
            ArtWork dasMaedchen = new("Das Mädchen");
            ArtWork sternenNacht = new("SternenNacht");


            //Liste von Artworks in den Räumen
            room1.AddArtwork(monalisa);
            room1.AddArtwork(derKuss);
            room2.AddArtwork(hassan);
            room3.AddArtwork(skulptur);
            room4.AddArtwork(shark);
            room5.AddArtwork(dasMaedchen);
            room5.AddArtwork(sternenNacht);



            //Liste von Räumen im Museum
            museum.AddRoom(room1);
            museum.AddRoom(room2);
            museum.AddRoom(room3);
            museum.AddRoom(room4);
            museum.AddRoom(room5);
            museum.AddRoom(hall1);
            museum.AddRoom(hallMain);

            //Liste von NachbarsRäumen
            room1.AddNeighbourList(room2);
            room1.AddNeighbourList(hallMain);

            room2.AddNeighbourList(room3);

            room3.AddNeighbourList(hall1);

            room4.AddNeighbourList(room5);

            hall1.AddNeighbourList(room3);
            hall1.AddNeighbourList(room4);
            hall1.AddNeighbourList(hallMain);



            //Print
            museum.PrintStructure();


            //Liste von Personen im Museum
            museum.EnterNewPerson(guest1);
            museum.EnterNewPerson(guest2);
            museum.EnterNewPerson(guest3);


            for (int i = 0; i < 10; i++)
            {
                museum.Tick();
            }
        }
    }
}

