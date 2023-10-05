

namespace Jovo.Week02
{
    public class Boolean
    {
        public static void Start()
        {
            int result = Add();
            Console.WriteLine("ergebniss " + result);
            Console.WriteLine("========================================");
            Console.WriteLine("aufgabe");
        }




        public static void Summe()
        {
            int result = 0;
            for (int i = 20; i  <= 50; i++) {
                result += i;
                Console.WriteLine(result);
            }
        }

        public static int Add()
        {
            int result = 0;
            for(int i = 20; i <= 50; i++)
            {
                result += i;
            }
            return result;
        }

        
        public static void Add2()
        {
            long result = 0;
            for(long i = 1; i <= 20; i++)
            {
                result *= i;
                Console.WriteLine(result);
            }
            
        }



















    }

        









    

}
