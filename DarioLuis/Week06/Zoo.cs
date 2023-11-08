using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week06
{
    public class Zoo
    {
        public static void Start()
        {
            Gehege();
        }
        public static void Gehege()
        {
            Console.WriteLine("-Zoo");
            Console.WriteLine("--|Gehege");
            Console.WriteLine("---|-Aquarium");
            Console.Write("----|-");
            Aquarium();
            
            Console.WriteLine("---|-Wolfsgehege");
            Console.Write("----|-");
            WolfsGehge();
        }
        public static void Aquarium()
        {
            String TiereAqua = "Schildkröte, Hai, Fisch";
            Console.WriteLine(TiereAqua);
        }
        public static void WolfsGehge()
        {
            String TiereWolf = "Wolf Peter, Wolf Frieda, Wolf Andre";
            Console.WriteLine(TiereWolf);
        }
    }
}
