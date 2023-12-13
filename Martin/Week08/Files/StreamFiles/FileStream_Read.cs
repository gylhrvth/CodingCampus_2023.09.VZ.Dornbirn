using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.Files.StreamFiles
{
    public class FileStream_Read
    {
        public static void Start()
        {

            //Console.WriteLine("Gib ein Text ein der in einer Textdokument gespeichert werden soll");
            //string text = Console.ReadLine();

            //WriteFile(text);

            //Console.WriteLine(text + " wurde erfolgreich hinzugefügt");

            CopyTo("C:\\Users\\Martin\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Martin\\Week08\\Hello.txt", "C:\\Users\\Martin\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Martin\\Week01\\Week01Test.txt");
           

        }
        public static void WriteFile(string text)
        {
            string path = "C:\\Users\\Martin\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Martin\\Week08\\Hello.txt";

            using (StreamWriter sw = new StreamWriter(path, true)) //erstellt textdokument
            {
                Console.WriteLine();
                sw.WriteLine(text); // schreibt einmal rein 

            }
        }

        public static void ReadFile()
        {
            string path = "C:\\Users\\Martin\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Martin\\Week08\\Hello.txt";

            using (StreamReader sr = new StreamReader(path)) //angeben was er lesen soll
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

            }
        }

        public static void CopyTo(string copy,string path)
        {


            using (StreamReader sr = new StreamReader(copy))
            {
                string line = sr.ReadLine();

                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(line);
                }

            }
        }
    }
}
