using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week11._1
{
    internal class Datenbank
    {












        public static string ConnectionString()
        {
            return "Persist Security Info=False;Initial Catalog=Mondial;server=tcp: localhost,1433;User=erikdittrich;Password=mmbbekjsix";

        }
    }
}
