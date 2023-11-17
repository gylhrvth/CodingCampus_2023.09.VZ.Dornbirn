using Riccardo.Week07.ZooDoopelmayer;
using System;

namespace Riccardo.Week07.ZooDoppelmayer
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo z = new Zoo("DoppelmayerZoo", 1963);

            z.SearchAndCreate("Vogelgehege");
            z.SearchAndCreate("Hünner");
            z.SearchAndCreate("Alpaka");

            z.PrintStructure();
        }
    }
}

