using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{
    internal class Entrance : Corridor
    {
        public Entrance(string name) : base(name) { }

        public override Artwork GetRandomArtwork()
        { return null; }
    }


}
