using System;
namespace David.Week09
{
    public class FileCopy
    {
        public static void Start()
        {
            string source = "/Users/davidisele/Projects/CodingCampus_2023.09.VZ.Dornbirn/David/Week08/Hell.txt";
            string destination = "/Users/davidisele/Projects/CodingCampus_2023.09.VZ.Dornbirn/David/Week08/Hello2.txt";
            CopyTo(source, destination);
        }


        public static void CopyTo(string source, string destination)
        {
            try //Versuche das folgende zu tun
            {//Verwende Lesen Quelle
                using (StreamReader sr = new StreamReader(source))
                {
                    using (StreamWriter sw = new StreamWriter(destination))
                    {
                        //zum zeile lesen
                        string line = sr.ReadLine();
                        //solange zeile nicht leer (etwas drin)
                        while (line != null)
                        {  //Dann scheibe zeile mit streamReader
                            sw.WriteLine(line);
                            //Dann lies Zeile mit sr (
                            line = sr.ReadLine();

                        }

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

