using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    internal class ZooMain
    {
        public static void Start()
        {
            Zoo tierGartenDornbirn = new Zoo("Tiergarten Dornbirn", 2023);
            Gehege alpenwiese = new Gehege("Alpenwiese");
            Gehege ried = new Gehege("Ried");
            Gehege terrariumWarm = new Gehege("Terrarium (Warm)");
            Tier rijska = new Tier("Rijska", "Kuh");
            Tier garmond = new Tier("Garmond", "Storch");
            Tier hugo = new Tier("Hugo", "Storch");
            Tier idaxis = new Tier("Idaxis", "Storch");
            Tier olaf = new Tier("Olaf", "Fisch");

            tierGartenDornbirn.Gehege.Add(alpenwiese);
            tierGartenDornbirn.Gehege.Add(ried);
            tierGartenDornbirn.Gehege.Add(terrariumWarm);

            alpenwiese.Tier.Add(rijska);
            ried.Tier.Add(garmond);
            ried.Tier.Add(hugo);
            ried.Tier.Add(idaxis);
            terrariumWarm.Tier.Add(olaf);


            tierGartenDornbirn.PrintZoo();
        }
    }
}
