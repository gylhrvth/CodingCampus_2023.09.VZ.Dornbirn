using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week09.HassanTutorial
{
    internal class ReadFile
    {
        public static void Start()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\nila\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Niklas\\Week09\\InputOutput\\InputText.txt"))
            {
                string Line = sr.ReadLine();
                while (Line != null)
                {
                    Console.WriteLine(Line);
                    Line = sr.ReadLine();
                }
            }
        }
    }
}
