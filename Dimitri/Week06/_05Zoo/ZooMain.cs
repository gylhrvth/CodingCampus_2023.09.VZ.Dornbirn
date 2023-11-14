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
            //show eurosign
            Console.OutputEncoding = Encoding.UTF8;

            List<Gehege> gehegeList = new();
            DateTime gruendungsJahr = new(1991, 04, 01);
            //Zoo myZoo = new("Zoo Goefis", new DateTime(1991), gehegeList);
            Zoo myZoo = new("Zoo Goefis", gruendungsJahr, gehegeList);

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
            Gehege terrarium = new("Terrarium");
            Zoo.AddGehege(myZoo, terrarium);

            //Waerter

            Waerter Hans = new("Hans");

            Waerter.AddGehege(Hans, katzenGehege);

            Waerter.AddGehege(Hans, vogelGehege);

            Waerter petra = new("Petra");

            Waerter.AddGehege(petra, schmetterlingsGehege);
            Waerter.AddGehege(petra, terrarium);

            Waerter Franziska = new("Franziska");
            Waerter.AddGehege(Franziska, schmetterlingsGehege);
            Waerter.AddGehege(Franziska, katzenGehege);

            Zoo.AddWarter(myZoo, Franziska);

            Zoo.AddWarter(myZoo, petra);

            Zoo.AddWarter(myZoo, Hans);

            //output

            myZoo.PrintZoo();

            myZoo.GetFutterbedarf();

            //Simulation
            Console.WriteLine();

            myZoo.Simulation();


        }


    }
}
