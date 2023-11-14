using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new("Tiergarten Dornbirn", 2022);
            zoo.PrintStructure();
        }

    }
}
