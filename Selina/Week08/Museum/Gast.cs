using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.Museum
{
    public class Gast
    {
        private string _Name;
        private Raum GastIstHier;
       
        public string Name {  get { return _Name; } }

        public Gast(string name)
        {
            this._Name = name;
            GastIstHier = null;
        }

        public void GehtZu(Raum raum)
        {
            if (raum == GastIstHier)
            {
                return;
            }

            if (GastIstHier != null)
            {
                GastIstHier.GastGeht(this);
            }

            GastIstHier = raum;
            GastIstHier.GastKommt(this);
        }
    }
}
