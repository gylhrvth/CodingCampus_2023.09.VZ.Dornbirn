using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week09.InputOutput
{
    internal class Read
    {
        public static void Start()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\nila\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Niklas\\Week09\\InputOutput\\InputText.txt"))
            {
                string Read = sr.ReadLine();
                while (Read != null)
                {
                    Console.WriteLine(Read);
                    Read = sr.ReadLine();
                }
            }
        }
    }
}
