using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week07.Museum
{
    internal class ExhibitionRoom : Room
    {
        private List<Artwork> _artworkList = new();
        public ExhibitionRoom(string name) : base(name) { }
    }
}
