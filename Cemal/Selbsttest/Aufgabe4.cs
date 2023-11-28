using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Selbsttest
{
    public class Aufgabe4
    {
        public Aufgabe4()
        {
            string currentdirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(currentdirectory);
            directoryInfo.GetFiles();
        }
    }
}
