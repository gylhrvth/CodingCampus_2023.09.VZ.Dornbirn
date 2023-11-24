using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Obj_Selbsttest.Filesystem
{
    internal class Aufgabe4
    {
        public static void Start()
        {
            var file = "C:\\Users\\nila\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Niklas";

            var getDir = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(getDir);
            Console.WriteLine(dir.Parent.Parent.Parent.Name);

            if (!Directory.Exists(file))
            {
                throw new DirectoryNotFoundException();
            }
            Console.WriteLine(file);
        }
    }
}
