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

            Tier emil = new("Emil", "Mitteleuropäische Kurzhaar", Hühnchen, 1, 200, 200, 50);
            Gehege.AddTier(katzenGehege, emil);
            Tier sandy = new("Sandy", "Mitteleuropäische Kurzhaar", Hühnchen, 0.75, 150, 150, 40);
            Gehege.AddTier(katzenGehege, sandy);
            Tier carlos = new("Carlos", "Mitteleuropäische Kurzhaar", Hühnchen, 1, 120, 120, 30);
            Gehege.AddTier(katzenGehege, carlos);
            Tier mimi = new("Mimi", "Mitteleuropäische Kurzhaar", Hühnchen, 0.75, 100, 100, 20);
            Gehege.AddTier(katzenGehege, mimi);
            Tier sauerFlatter = new("Sauerflatter", "Zitronenfalter", Zuckerwasser, 0.001, 10, 10, 1);
            Gehege.AddTier(schmetterlingsGehege, sauerFlatter);
            Tier Monarch = new("King", "Monarchfalter", Zuckerwasser, 0.005, 20, 20, 3);
            Gehege.AddTier(schmetterlingsGehege, Monarch);
            Tier Pfauenauge = new("Auge", "Tagpfauenauge", Zuckerwasser, 0.003, 15, 15, 2);
            Gehege.AddTier(schmetterlingsGehege, Pfauenauge);
            Tier rotKehle = new("Mitrotemhals", "Rotkehlchen", Korn, 0.01, 40, 40, 5);
            Gehege.AddTier(vogelGehege, rotKehle);
            Tier Rabe = new("Schwarzefeder", "Rabe", Korn, 0.5, 80, 80, 15);
            Gehege.AddTier(vogelGehege, Rabe);
            Tier Steinadler = new("Gipfelstürmer", "Steinadler", Hühnchen, 1.5, 250, 250, 40);
            Gehege.AddTier(vogelGehege, Steinadler);
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

            TierArzt Kathi = new("Kathi");

            myZoo.AddTierArzt(Kathi);

            //output

            myZoo.PrintZoo();

            myZoo.GetFutterbedarf();

            //Simulation
            Console.WriteLine();

            //myZoo.Simulation0Old();

            //myZoo.Simulation0();

            //Console.WriteLine();

            ////myZoo.Simulation1Old();

            //Console.WriteLine();

            //myZoo.Simulation1();

            myZoo.Simulation(5);

            //myZoo.Simulation2();
        }


    }
}
