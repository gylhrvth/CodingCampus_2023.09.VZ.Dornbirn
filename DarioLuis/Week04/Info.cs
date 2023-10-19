namespace DarioLuis.Week04
{
    public class Info
    {


        public static void Start()
        {


            try
            {
                
                //Name
                Console.Write("Hallo, mit wem rede ich gerade? ");
                string name = Console.ReadLine();

                
                //Alter
                Console.Write("Hallo " + name + ", wie alt bist du?");
                int age = Convert.ToInt32(Console.ReadLine());


                if (age > 110)
                {
                    Console.WriteLine("Langsam würd es Zeit anfangen zu graben, oder nicht?");
                }
                else if (age <= 0)
                {
                    Console.WriteLine("Du wurdest noch garnicht geboren?");
                }
                else
                {
                    //Info
                    Console.WriteLine("Dies ist deine Info:");
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Alter: " + age);
                }
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Gib bitte eine gültige Zahl zwischen 1-110!!");

            }
        }

    }
}

