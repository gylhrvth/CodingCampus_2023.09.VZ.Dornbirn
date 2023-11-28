using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem
{
    public class WriteFile
    {
        public static void Start()
        {
            string pastehere = "C:\\Users\\aau21982\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Simon\\Week08\\Filesystem\\Hello2.txt";
            string copyme = "C:\\Users\\aau21982\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Simon\\Week08\\Filesystem\\Hello.txt";

            CopyTxt(copyme, pastehere);
        }

        public static void CopyTxt(string copyme, string pastehere)
        {

            using (StreamReader sr = new(copyme))
            {
                string line = sr.ReadToEnd();
                //while (line != null)
                //{
                //    Console.WriteLine(line);
                //    line = sr.ReadLine();
                //}
                using (StreamWriter sw = new StreamWriter(pastehere))
                {
                    string test = line.ToUpper();
                    sw.WriteLine(test);
                }
            }
            
            
        }
        
    }
}
