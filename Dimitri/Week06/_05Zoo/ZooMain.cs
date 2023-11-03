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
            Gehege katzenGehege = new("Katzengehege");
            Gehege schmetterlingsGehege = new("Schmetterlingsgehege");
            Gehege vogelGehege = new("Vogelgehege");

            Zoo.AddGehege(myZoo, katzenGehege);
            Zoo.AddGehege(myZoo, schmetterlingsGehege);
            Zoo.AddGehege(myZoo, vogelGehege);

            //Console.WriteLine(myZoo);
            //Console.WriteLine(katzenGehege);

            //foreach(string gehege in myZoo.Gehege.Name)
            //{

            //}

            myZoo.PrintZoo();




        }


    }
}
