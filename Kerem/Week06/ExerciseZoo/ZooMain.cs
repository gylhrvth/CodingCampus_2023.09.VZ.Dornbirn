using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06.ExerciseZoo
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo z = new Zoo("Wano Kuni", 2018);

            Enclosure meadow = new Enclosure("Meadow", "Outdoor/Ground", "Outside Temperature");
            
            z.PrintZoo();
            z.addEnclosure(meadow);
            


        }


    }
}
