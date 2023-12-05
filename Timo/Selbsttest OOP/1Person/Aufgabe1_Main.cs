namespace Timo.Selbsttest_OOP._1Person
{
    public class Aufgabe1_Main
    {
        public static void Start()
        {
            Person P1 = new("Günther", 53, Gender.male);
            Person P2 = new("Sabine", 119, Gender.female);
            Person P3 = new("Stefan", 27, Gender.male);
            Person P4 = new("Veronika", 89, Gender.female);
            Person P5 = new("Daria", 18, Gender.divers);
            Person P6 = new("Günther2", 53, Gender.male);
            Person P7 = new("Sabine2", 119, Gender.female);
            Person P8 = new("Stefan2", 27, Gender.male);
            Person P9 = new("Veronika2", 89, Gender.female);
            Person P10 = new("Daria2", 18, Gender.divers);

            Console.WriteLine(P1.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(P2.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(P3.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(P4.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(P5.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(P6.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(P7.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(P8.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(P9.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(P10.ToString());
        }
    }
}
