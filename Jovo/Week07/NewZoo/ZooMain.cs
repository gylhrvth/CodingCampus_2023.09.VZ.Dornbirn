using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week07.NewZoo
{
    internal class ZooMain
    {
        public static void Start()
        {
            //Zoo
            Zoo zoo = new Zoo("Lastia", "Frankfurt", 2021, 3);
            //Enclosures
            Enclosures meadow = new Enclosures("Meadow", "Flat meadow", "Warm 25°");
            Enclosures WaterTank = new Enclosures("WaterTank", "Unter Wasser", "Cold 5°");
            Enclosures Mountains = new Enclosures("Mountains", "Mountains/Snow", "Cold 0°");




            zoo.PrintZoo();










        }
        






    }
}
