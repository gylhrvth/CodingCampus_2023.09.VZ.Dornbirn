using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week09
{
    internal class WriteFiles
    {
        public static void Start() 
        {

            //gehe auf den ordner/file von der du den dateiweg haben willst drücke rechtsklick : dateipfad kopieren
            //using wird verwendet um die  simulation zu schließen//speicher blockiert
            //using: es muss jede datei geschlossen werden: wenn es etwas öffnet schließt es auch wieder
            //beim start wird dein text ausgegeben in eine text dokument
            using (StreamWriter sw = new StreamWriter("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Jovo\\Week09\\Hello.txt"))
            {
                sw.WriteLine("Hello World!!" );
            }
        
        }

    }
}
