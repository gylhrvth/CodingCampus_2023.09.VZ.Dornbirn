using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.MuseumNew
{
    public class MuseumMain
    {
        public static void Start()
        {

            Museum museum = new Museum("Pinakothek");

            ExhibitionRoom room1 = new("BilderGalerie");
            ExhibitionRoom room2 = new("StatuenGalerie");
            ExhibitionRoom room3 = new("KunstaustellungsRaum");
            ExhibitionRoom room4 = new("DinosaurierRaum");
            ExhibitionRoom room5 = new("SteinzeitRaum");

            Hallway hall1 = new Hallway("Gang1");
            HallwayMain hallMain = new HallwayMain("Haupteingang");

            //Liste von Räumen im Museum
            museum.AddRoom(room1);
            museum.AddRoom(room2);
            museum.AddRoom(room3);
            museum.AddRoom(room4);
            museum.AddRoom(room5);
            museum.AddRoom(hall1);
            museum.AddRoom(hallMain);

            //Liste von NachbarsRäumen
            room1.AddNeighbour(room2);
            room1.AddNeighbour(hallMain);

            room2.AddNeighbour(room3);

            room3.AddNeighbour(hall1);

            room4.AddNeighbour(room5);
            
            hall1.AddNeighbour(room3);
            hall1.AddNeighbour(room4);
            hall1.AddNeighbour(hallMain);



            //Print
            museum.PrintStructure();
        }






    }
}
