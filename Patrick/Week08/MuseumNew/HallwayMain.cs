using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.MuseumNew
{
    public class HallwayMain : Hallway
    {
        private bool _IsOpen;

        public HallwayMain( string name) : base(name)
        {
            _IsOpen = true;
        }
    }
}
