using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week07.Vererbung
{
    internal class Garage
    {

        public static void Start()
        {

            List<Sportwagen> garage = new List<Sportwagen>();

            garage.Add(new Sportwagen("Lambo", 2000));
            garage.Add(new Sportwagen("königsegg", 2005));
            garage.Add(new Porsche("Porsche GT3 RS", 2020, 2000000));
            garage.Add(new Bugatti("Bugatti Veyron", 2023, "Dubai"));

            foreach(Sportwagen sportwagen in  garage) 
            {
                sportwagen.PrintMe();
            
            }





        }
    }
}
