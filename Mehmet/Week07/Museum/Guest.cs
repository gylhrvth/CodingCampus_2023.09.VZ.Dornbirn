using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{

    internal class Guest : Human
    {
        Random random = new Random();
        private bool _isTired = false;
        private int _EnergyCount;



        public Guest(string name, int energyCount, Room currentRoom) : base(name, currentRoom)
        {
            _EnergyCount = energyCount;
        }

        public override bool HumanAction()
        {
            if (_EnergyCount <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("----> Energy Count of {0} is {1}", _Name, _EnergyCount);
                Console.WriteLine("----> {0} is tired and goes home.", _Name);
                Console.ResetColor();
                _currentRoom.RemoveHuman(this);
                return true;
            }
            if (random.Next(0, 3) != 1)
            {
                Artwork artwork = _currentRoom.GetRandomArtwork();
                if (artwork != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    //Console.WriteLine("----> Energy Count of {0} is {1}", _Name, _EnergyCount);
                    Console.WriteLine("----> {0} is looking at {1} in {2}", _Name, artwork.ArtName, _currentRoom.name);
                    Console.ResetColor();
                    _EnergyCount--;
                    return true;
                }
            }

            return false;

        }

    }
}
