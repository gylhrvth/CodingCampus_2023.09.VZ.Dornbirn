using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dimitri.Week06._05Zoo
{
    internal class ZooMain
    {
        public static void Main()
        {
            List<Gehege> gehegeList = new List<Gehege>();
            Zoo myZoo = new("Zoo Goefis", 1991, gehegeList);

            List<Tier> katzenGehegeList = new();
            List<Tier> schmetterlingsGehegeList = new();
            List<Tier> vogelGehegeList = new();
            Gehege katzenGehege = new("Katzengehege", katzenGehegeList);
            Gehege schmetterlingsGehege = new("Schmetterlingsgehege", schmetterlingsGehegeList);
            Gehege vogelGehege = new("Vogelgehege", vogelGehegeList);

            Zoo.AddGehege(myZoo, katzenGehege);
            Zoo.AddGehege(myZoo, schmetterlingsGehege);
            Zoo.AddGehege(myZoo, vogelGehege);

            Tier emil = new("Emil", "Mitteleuropäische Kurzhaar");
            Gehege.AddTier(katzenGehege, emil);
            Tier sandy = new("Sandy", "Mitteleuropäische Kurzhaar");
            Gehege.AddTier(katzenGehege, sandy);

            Tier sauerFlatter = new("Sauerflatter", "Zitronenfalter");
            Gehege.AddTier(schmetterlingsGehege, sauerFlatter);


            Tier rotKehle = new("Mitrotemhals", "Rotkehlchen");
            Gehege.AddTier(vogelGehege, rotKehle);

            Zoo.AddGehege(myZoo, new Gehege("Terrarium", new List<Tier>()));

            myZoo.PrintZoo();




        }


    }
}
