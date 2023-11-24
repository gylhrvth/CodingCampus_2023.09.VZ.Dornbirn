using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{
    public class Guard : Human
    {
        public Guard(string name, Room currentRoom) : base(name, currentRoom) { }

        public override bool HumanAction()
        {
            if (_currentRoom.CountGuards() > 0)
            {
                return false;
                //martin was here
            }
            else if (_currentRoom.CountPeople() > 1 && _currentRoom.GetRandomArtwork() != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Guard {_Name} stays in {_currentRoom.name}.");
                Console.ResetColor();
                return true;
            }
            return false;
        }
    }
}
