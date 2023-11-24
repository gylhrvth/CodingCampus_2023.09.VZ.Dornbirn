using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Üben.Selbttest2.Files
{
    internal class Aufgabe4
    {

        public static void Start()
        {

            


            //den dateipfad aufrufen
            string currentDirectory = Directory.GetCurrentDirectory();
            //den aufgerufenen dateipfad ausdrücken
            Console.WriteLine("currentDirectory:" + currentDirectory);
          

            //dateipfad infos holen (damit ich dann wirklich die infos der dateien ausdrucken kann
            //ansonsten kann ich keine spezifischen sachen ausdrucken
            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);
            //drücke die gewollten daten aus (kann man aussuchen nach dem punkt (.)  )
            Console.WriteLine(currentDirectoryInfo.Name);


            //springe zurück in den ordnern und wähle den gewollten ordner aus(am ende muss man FullName schreiben)
            string projectRootDirectory = currentDirectoryInfo.Parent.Parent.Parent.FullName;
            //drücke die ordner aus
            Console.WriteLine(projectRootDirectory);
            


            //.GetFiles wird verwendet um die dateien von currentDirectoryInfo zu holen
            //im ordner die ordner/files werden mit .GetFiles geholt ansonsten weiß er ja nicht was drinnen ist
            foreach(  var file in currentDirectoryInfo.GetFiles())
            {
                Console.WriteLine(file.Length);
            }



        }
    }
}
