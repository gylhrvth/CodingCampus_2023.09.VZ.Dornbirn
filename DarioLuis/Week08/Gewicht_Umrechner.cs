using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lukas.Week08
{
    public class Gewicht_Umrechner
    {
        public static void Start()
        {
            First();
            Call_Calculate();
        }

        public static void First()
        {
            Console.Write("Hallo das ist der Gewichtrechner von Dario.");
            Console.WriteLine("(Dario Andrade, 2023, © Copyright for all Rights for Dario Andrade)");
        }
        public static void Call_Calculate()
        {
            Console.WriteLine("Hallo welches Gewicht hast du gerade?(g, kg)");
            string entry = Console.ReadLine().ToLower();

            Console.WriteLine("In welches Gewicht magst du Umrechen?(µg, mg, g, kg, t, gt)");
            string subentry = Console.ReadLine().ToLower();

            //kg
            if(entry == "kg")
            {
                Console.WriteLine("Wie viel Kg magst du umrechnen?");
                int numb = Convert.ToInt32(Console.ReadLine());

                //kg in mikrogramm
                if (subentry == "µg")
                {
                    double endkgµg = numb / 0.0000000010000;
                    Console.Write(numb + " in Mikrogramm: ");
                    Console.Write(endkgµg);
                    Console.WriteLine("µg");
                }

                //kg in milligramm
                if (subentry == "mg")
                {
                    double endkgmg = numb * 1000 * 1000;
                    Console.Write(numb + " in Milligramm: ");
                    Console.WriteLine(endkgmg + "mg");
                }

                //kg in gramm
                if (subentry == "g")
                {
                    double endkgg = numb * 1000;
                    Console.Write(numb + " in Gramm: ");
                    Console.WriteLine(endkgg + "g");
                }

                //kg in kg
                if (subentry == "kg")
                {
                    Console.WriteLine("Bist nicht gerade der schlauste oder? " + numb + " = " + numb);

                }

                //kg in tonne
                if (subentry == "t")
                {
                    double endkgt = numb / 1000;
                    Console.Write(numb + " als Tonne: ");
                    Console.WriteLine(endkgt + "t");
                }
                
                //kg in gigatonne
                if (subentry == "gt")
                {
                    double endkggt = numb / 1000 / 1000;
                    Console.Write( numb + " als Gigatonne: ");
                    Console.WriteLine(endkggt + "gt");
                }
            }

            //=======================================
            //gramm

            //g
            if (entry == "g")
            {
                Console.WriteLine("Wie viel g magst du umrechnen?");
                int numb = Convert.ToInt32(Console.ReadLine());

                //g in mikrogramm
                if (subentry == "µg")
                {
                    double endkgµg = numb * 1000000;
                    Console.Write(numb + " in Mikrogramm: ");
                    Console.Write(endkgµg);
                    Console.WriteLine("µg");
                }

                //g in milligramm
                if (subentry == "mg")
                {
                    double endkgmg = numb * 1000;
                    Console.Write(numb + " in Milligramm: ");
                    Console.WriteLine(endkgmg + "mg");
                }

                //g in gramm
                if (subentry == "kg")
                {
                    double endkgg = numb / 1000;
                    Console.Write(numb + " in Gramm: ");
                    Console.WriteLine(endkgg + "kg");
                }

                //g in kg
                if (subentry == "g")
                {
                    Console.WriteLine("Bist nicht gerade der schlauste oder? " + numb + " = " + numb);

                }

                //g in tonne
                if (subentry == "t")
                {
                    double endkgt = numb / 1000 / 1000;
                    Console.Write(numb + " als Tonne: ");
                    Console.WriteLine(endkgt + "t");
                }

                //g in gigatonne
                if (subentry == "gt")
                {
                    long  endkggt = numb / 1000 / 1000 / 1000;
                    Console.Write(numb + " als Gigatonne: ");
                    Console.WriteLine(endkggt + "gt");
                }
            }
        }
    }
}
