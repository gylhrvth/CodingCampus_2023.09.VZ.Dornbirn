using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07.Vererbung
{
    public class TastaturMain
    {
        public static void Start()
        {
            List<Tastatur> TastaturShop = new List<Tastatur>();

            TastaturShop.Add(new Tastatur("Razer huntsMini", true));
            TastaturShop.Add(new Tastatur("Logitech X Pro",false));
            TastaturShop.Add(new RGBTastatur("RGB RAZER", false, "rainbow"));

            foreach(Tastatur t in TastaturShop)
            {
                t.PrintTastatur();

                Console.WriteLine(); //abstand
            }
        }
    }
}
