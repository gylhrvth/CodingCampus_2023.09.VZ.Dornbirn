namespace Gheorghe
{
    public class Kurse_und_Trainer
    {



        public static void Start()
        {


            Kurs Kurs1 = new Kurs("Programmierunug", DateTime.Now, 100, 840, new Mensch(188, 21, "Luca", 80));

            Console.WriteLine(Kurs1);


        }
    }
}
