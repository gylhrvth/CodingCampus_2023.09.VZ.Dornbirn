namespace Gheorghe.Week02
{
    internal class Zaehlen
    {
        public static void Start()

        {
            for (float i = 0; i <= 100; i += 0.1f)

            {
                Console.WriteLine("Resultdigit 1 = {0,-3:0.0}", i);
                Console.WriteLine("Resultdigit 2 = {0,7:N2}", i);
            }

        }

    }
}

