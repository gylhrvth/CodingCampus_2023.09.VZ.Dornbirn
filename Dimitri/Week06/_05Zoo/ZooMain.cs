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

            List<Tier> katzenGehegeList = new();
            List<Tier> schmetterlingsGehegeList = new();
            List<Tier> vogelGehegeList = new();
            Gehege katzenGehege = new("Katzengehege", katzenGehegeList);
            Gehege schmetterlingsGehege = new("Schmetterlingsgehege", schmetterlingsGehegeList);
            Gehege vogelGehege = new("Vogelgehege", vogelGehegeList);

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

            Zoo.AddGehege(myZoo, new Gehege("Terrarium", new List<Tier>()));

            myZoo.PrintZoo();


            //for (int i = 0; i < myZoo.Gehege.Count; i++)
            //{
            //    Console.WriteLine("{0}", myZoo.Gehege[i]);

            //    for (int j = 0; j < myZoo.Gehege[i].Tiere.Count; j++)
            //    {
            //        Console.WriteLine("{0}", myZoo.Gehege[i].Tiere[j].Name);

            //    }
            //}


            myZoo.GetFutterbedarf(myZoo);
        }


    }
}
