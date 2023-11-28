using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08.Museum
{
    internal class Thief : Human
    {
        private List<Artwork> _StolenItems = new();
        
        public Thief(string name, Room currentRoom) : base(name, currentRoom) { }
        public override bool HumanAction() 
        {
            Artwork artwork = _currentRoom.GetRandomArtwork();

            if (artwork != null && _currentRoom.CountPeople() == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"----> {_Name} is alone and steals {artwork.ArtName} in {_currentRoom.name}.");
                _currentRoom.RemoveArtwork(artwork);
                _StolenItems.Add(artwork);
                Museum._ArtworkCount--;
                Console.ResetColor();
               
                return true;
            }
            return false;
        }

    }
}
