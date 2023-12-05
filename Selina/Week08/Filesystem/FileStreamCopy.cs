using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week08.Filesystem
{
    public class FileStreamCopy
    {
        public static void Start()
        {
            string path = @"C:\Users\wpfsebr\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Selina\Week08\Filesystem\ReadFile.cs";

            using (FileStream fs = File.OpenRead(path))
            {

            }

        }
      
    }
}
