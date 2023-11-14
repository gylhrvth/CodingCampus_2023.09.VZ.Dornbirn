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
            Console.OutputEncoding = Encoding.UTF8;
            List<Gehege> gehegeList = new();
            Zoo myZoo = new("Zoo Goefis", 1991, gehegeList);

            Gehege katzenGehege = new("Katzengehege");
            Gehege schmetterlingsGehege = new("Schmetterlingsgehege");
            Gehege vogelGehege = new("Vogelgehege");

            Zoo.AddGehege(myZoo, katzenGehege);
            Zoo.AddGehege(myZoo, schmetterlingsGehege);
            Zoo.AddGehege(myZoo, vogelGehege);

            Futter Hühnchen = new("Hühnchen", "kg", 5.99);

            Futter Korn = new("Sonnenblumenkerne", "kg", 1.95);

            Futter Zuckerwasser = new("Fruchtsaft", "l", 1.29);

            Tier emil = new("Emil", "Mitteleuropäische Kurzhaar", Hühnchen, 1);
            Gehege.AddTier(katzenGehege, emil);
            Tier sandy = new("Sandy", "Mitteleuropäische Kurzhaar", Hühnchen, 0.75);
            Gehege.AddTier(katzenGehege, sandy);
            Tier sauerFlatter = new("Sauerflatter", "Zitronenfalter", Zuckerwasser, 0.001);
            Gehege.AddTier(schmetterlingsGehege, sauerFlatter);
            Tier rotKehle = new("Mitrotemhals", "Rotkehlchen", Korn, 0.01);
            Gehege.AddTier(vogelGehege, rotKehle);

            Zoo.AddGehege(myZoo, new Gehege("Terrarium"));

            //Waerter

            Waerter Hans = new("Hans");

            Waerter.AddGehege(Hans, katzenGehege);

            Zoo.AddWarter(myZoo, Hans);

            //output

            myZoo.PrintZoo();

            myZoo.GetFutterbedarf(myZoo);

        }


    }
}
