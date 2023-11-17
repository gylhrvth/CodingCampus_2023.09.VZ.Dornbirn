using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07.Vererbung
{
    public class TastaturMain
    {
        private string _Name;
        private bool _HasLoudSound;

        public TastaturMain(string name, bool hasLoudSound)
        {
            _Name = name;
            _HasLoudSound = hasLoudSound;
        }
    }
}
