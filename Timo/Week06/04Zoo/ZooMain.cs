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

            Futter grass = new Futter("Gras", "kg", 0.23);
            Futter mouse = new Futter("Maus", "Stück", 0.9);
            Futter insects = new Futter ("Insekten", "Stück", 0.04);

            Tier rijska = new Tier("Rijska", "Kuh", grass, 37);
            Tier garmond = new Tier("Garmond", "Storch", mouse, 20);
            Tier hugo = new Tier("Hugo", "Storch", mouse, 35);
            Tier idaxis = new Tier("Idaxis", "Storch", mouse, 13);
            Tier olaf = new Tier("Olaf", "Chameleon",insects, 50);

            rijska.FoodList.Add(grass);
            garmond.FoodList.Add(mouse);
            hugo.FoodList.Add(mouse);
            idaxis.FoodList.Add(mouse);
            olaf.FoodList.Add(insects);

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
