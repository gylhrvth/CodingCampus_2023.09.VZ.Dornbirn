using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week09.FileSystem
{
    public class WriteFile
    {
        public static void Start()
        {
            using(StreamWriter sw = new StreamWriter("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Patrick\\Week09\\FileSystem\\Hello.txt"))        //....\\Hello.txt. Datei wird erstellt
            {
                sw.WriteLine("Hello World!!");          //In der Textdatei steht Hello World!!
                sw.WriteLine("Hello World2!!");         //zusätzliche Zeile mit Hello World2!! 
            }

            using (StreamWriter sw2 = new StreamWriter("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Patrick\\Week09\\FileSystem\\FileStreamWrite.txt"))        //....\\Hello.txt. Datei wird erstellt
            {
                string a = Console.ReadLine();
                sw2.WriteLine(a);          //In der Textdatei steht Hello World!!              
            }
        }
    }
}
