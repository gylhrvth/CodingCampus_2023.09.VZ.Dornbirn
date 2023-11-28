using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week08.Museum
{
    internal class Corridor : Room
    {
        public Corridor(string name) : base(name)
        {

        }
        public override Artwork GetRandomArtwork()
        { return null; }

    }
}
