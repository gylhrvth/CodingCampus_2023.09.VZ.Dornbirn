using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{
    public class Museum
    {
        private string _Name;
        private List<Room> _RoomList = new();
        public static List<Human> _CheckedHumans = new();
        public static int _ArtworkCount = 16;



        public Museum(string name)
        {
            _Name = name;
        }

        public void AddRoom(Room room)
        {
            _RoomList.Add(room);
        }

        public void Simulation()
        {
            foreach (Room room in _RoomList)
            { 
                room.CheckHumanList();

            }         
            
            ConsoleColor[] colors = new ConsoleColor[6] { ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.DarkMagenta };
            string toPrint = $"There are {_ArtworkCount} artworks left!!!";

            int index = 3;
            foreach(char c in toPrint)
            {
                Console.ForegroundColor = colors[index % 6];
                Console.Write(c);
                index++;
            }
            Console.WriteLine();
            Console.ResetColor();
        }


    }
}
