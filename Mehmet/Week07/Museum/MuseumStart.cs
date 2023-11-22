using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{
    public class MuseumStart
    {
        public static void Start()
        {
            Museum museum = new Museum("DCV-Museum");

            ExhibitionRoom[] exRooms = new ExhibitionRoom[8];

            for (int i = 0; i < exRooms.Length; i++)
            {
                exRooms[i] = new ExhibitionRoom("exRoom" + (i + 1));
                museum.AddRoom(exRooms[i]);
            }

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

            Human human1 = new Human("Martin", entrance);
            Human human2 = new Human("Peter", entrance);
            Human human3 = new Human("Susi", entrance);
            Human human4 = new Human("Vladimir", entrance);

            entrance.AddHuman(human1);
            entrance.AddHuman(human2);
            entrance.AddHuman(human3);
            entrance.AddHuman(human4);

            museum.Simulation();




            





        }
    }
}
