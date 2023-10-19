using System;


namespace DarioLuis.Week04
{
    public class DarioDaten
    {
        public static void Start()
        {
            //persöhnliche Daten
            String Name = "Dario Luis Andrade Gider";
            String num = "+436602855917";
            String gb = "10.07.06";
            String str = "Sebastianstraße 31a";
            String str2 = "Chronist-Frick Weg 3";
            String plz = "6800";

            Console.Write("Hallo wie heißt du?");
            string name = Console.ReadLine();

            if (name == "Dario")
            {
                Console.Write("Hallo " + name + ", wie alt bist du?");
                int age = Convert.ToInt32(Console.ReadLine());

                if(age == 17)
                {
                    Console.WriteLine("Gib bitte noch dein geheimes Passwort ein:");
                    String pas = Console.ReadLine();
                    if (pas == "penis")
                    {
                    Console.WriteLine("Hallo " + name + "(" + age + "), schön von dir zu hören, hier sind deine Daten");
                    Console.WriteLine(Name);
                    Console.WriteLine(gb);
                    Console.WriteLine(num);
                    Console.WriteLine("Hauptwohnort: " + str + "/" + plz);
                    Console.WriteLine("Zweitwohnort: " + str2 + "/" + plz);
                    }else
                    {
                        Console.WriteLine("Das war das falsche Passwort!!!");
                        Console.WriteLine("Aus Sicherheitsgründen können sie nicht mehr einloggen. Sie müssen das Program schließen und wieder öffnen");
                    }
                }
                else
                {
                    Console.WriteLine("Der Zugriff auf diese Daten wurde verweigert!");
                    Console.WriteLine("Aus Sicherheitsgründen können sie nicht mehr einloggen. Sie müssen das Program schließen und wieder öffnen");
                }
            }else
            {
                Console.WriteLine("Der Zugriff auf diese Daten wurde verweigert!");
                Console.WriteLine("Aus Sicherheitsgründen können sie nicht mehr einloggen. Sie müssen das Program schließen und wieder öffnen");
            }
        }
    }
}
