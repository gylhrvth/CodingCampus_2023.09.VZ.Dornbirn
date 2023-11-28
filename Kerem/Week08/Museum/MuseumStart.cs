using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08.Museum
{
    public class MuseumStart
    {
        public static void Start()
        {
            Museum museum = new Museum("DCV-Museum");

            //Create artworks
            Drawing drawing1 = new Drawing("MonaLisa");
            Drawing drawing2 = new Drawing("Spongebob");
            Drawing drawing3 = new Drawing("DaVinci");
            Drawing drawing4 = new Drawing("Picasso");

            Statue statue1 = new Statue("Gheorghe");
            Statue statue2 = new Statue("Gyula");
            Statue statue3 = new Statue("Lukas");
            Statue statue4 = new Statue("Nude Mehmet");

            ObjectsOfArt oOa1 = new ObjectsOfArt("RGB-Tastatur");
            ObjectsOfArt oOa2 = new ObjectsOfArt("Comodore64");
            ObjectsOfArt oOa3 = new ObjectsOfArt("Apple I");

            Painting painting1 = new("Der Schrei");
            Painting painting2 = new("Wie die Madonna");
            Painting painting3 = new("Sternen Nacht");
            Painting painting4 = new("Tadeus");
            Painting painting5 = new("Ericosinus");

      

            ExhibitionRoom[] exRooms = new ExhibitionRoom[8];

            for (int i = 0; i < exRooms.Length; i++)
            {
                exRooms[i] = new ExhibitionRoom("exRoom" + (i + 1));
                museum.AddRoom(exRooms[i]);
                //exRooms[i].AddArtwork(drawing1);
            }

            // Add artworks to room

            exRooms[0].AddArtwork(drawing1);
            exRooms[1].AddArtwork(drawing2);
            exRooms[2].AddArtwork(drawing3);
            exRooms[3].AddArtwork(drawing4);
            exRooms[4].AddArtwork(statue1);
            exRooms[5].AddArtwork(statue2);
            exRooms[6].AddArtwork(statue3);
            exRooms[7].AddArtwork(statue4);
            exRooms[0].AddArtwork(painting1);
            exRooms[1].AddArtwork(painting2);
            exRooms[2].AddArtwork(painting3);
            exRooms[3].AddArtwork(painting4);
            exRooms[4].AddArtwork(painting5);
            exRooms[5].AddArtwork(oOa1);
            exRooms[6].AddArtwork(oOa2);
            exRooms[7].AddArtwork(oOa3);


            Corridor[] corrRooms = new Corridor[4];

            for (int i = 0; i < corrRooms.Length; i++)
            {
                corrRooms[i] = new Corridor("corr" + (i + 1));
                museum.AddRoom(corrRooms[i]);
            }

            Entrance entrance = new Entrance("Entrance");
            museum.AddRoom(entrance);

            //Entrance
            entrance.AddRoom(corrRooms[1]);
            entrance.AddRoom(corrRooms[2]);
            //Corr2
            corrRooms[1].AddRoom(entrance);
            corrRooms[1].AddRoom(exRooms[1]);
            //Corr1
            corrRooms[0].AddRoom(exRooms[0]);
            //ExRoom1
            exRooms[0].AddRoom(exRooms[2]);
            //ExRoom3
            exRooms[2].AddRoom(exRooms[0]);
            exRooms[2].AddRoom(exRooms[4]);
            //ExRoom5
            exRooms[4].AddRoom(exRooms[2]);
            exRooms[4].AddRoom(exRooms[6]);
            //ExRoom7
            exRooms[6].AddRoom(corrRooms[3]);
            exRooms[6].AddRoom(exRooms[4]);
            //Corr4
            corrRooms[3].AddRoom(corrRooms[2]);
            corrRooms[3].AddRoom(exRooms[6]);
            corrRooms[3].AddRoom(exRooms[7]);
            //ExRoom8
            exRooms[7].AddRoom(exRooms[5]);
            exRooms[7].AddRoom(corrRooms[3]);
            //ExRoom6
            exRooms[5].AddRoom(exRooms[7]);
            exRooms[5].AddRoom(exRooms[3]);
            //ExRoo4
            exRooms[3].AddRoom(exRooms[5]);
            exRooms[3].AddRoom(exRooms[1]);
            exRooms[3].AddRoom(corrRooms[2]);
            //ExRoom2
            exRooms[1].AddRoom(exRooms[3]);
            exRooms[1].AddRoom(corrRooms[1]);
            //Corr3
            corrRooms[2].AddRoom(exRooms[3]);
            corrRooms[2].AddRoom(corrRooms[3]);
            corrRooms[2].AddRoom(entrance);

            Guest human1 = new Guest("Martin", 7, entrance);
            Guest human2 = new Guest("Peter", 11, entrance);
            Guest human3 = new Guest("Susi", 10, entrance);
            Guest human4 = new Guest("Vladimir", 10, entrance);

            Thief thief1 = new Thief("Kowalski", entrance);
            Thief thief2 = new Thief("Dimitri", entrance);


            Guard guard1 = new Guard("Türsteher Jovo", entrance);
            Guard guard2 = new Guard("Türsteher Ovoj", entrance);


            entrance.AddHuman(human1);
            entrance.AddHuman(human2);
            entrance.AddHuman(human3);
            entrance.AddHuman(human4);

            entrance.AddHuman(thief1);
            entrance.AddHuman(thief2);

            entrance.AddHuman(guard1);
            entrance.AddHuman(guard2);




            for (int i = 0; i < 72; i++)
            {
                
                Console.WriteLine("Simulation hour {0}", i + 1);
                Console.WriteLine();
                museum.Simulation();
                Museum._CheckedHumans.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(5000);
            }











        }
    }
}
