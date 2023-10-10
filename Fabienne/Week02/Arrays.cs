using System.Globalization;

namespace Fabienne.Week02
{
    public class Arrays
    {
        public static void Start()
        {
            int[] original = { 1, 2, 3 };
            makeACopy(original);
            NumberArray();
        }

        public static void NumberArray()
        {
            int[] num1 = new int[10];
            int[] num2 = new int[10];

            for (int i = 1; i < num1.Length; ++i)
            {
                num1[i] = i;
                Console.WriteLine(num1[i]);
            }
            Console.WriteLine();

            for (int i = num2.Length - 1; i > 0; i--)
            {
                num2[i] = i;
                Console.WriteLine(num2[i]);
            }
        }

        public static int[] makeACopy(int[] original)
        {
            int[] abc = new int[original.Length];

            for (int i = 0; i < 10; i++) 
            {
                
            }

            return null;
#

        }
    }
}
