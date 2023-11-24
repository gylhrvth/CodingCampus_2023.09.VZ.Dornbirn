namespace Gheorghe.Week02
{
    internal class Arrays
    {
        public static void Start()
        {
            createArrayIncreas(15);



        }

        public static int[] createArrayIncreas(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }
            return array;
        }


    }
}




