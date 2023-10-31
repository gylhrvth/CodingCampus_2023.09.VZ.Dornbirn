namespace DarioLuis.Week06
{
    public class Listv2
    {
        public static void Start()
        {
            List<int> list = CreateList(20);
            PrintList(list);
        }
        public static void PrintList(List<int> values)
        {
            Random random = new Random();

            int lenght = 6;


            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    

                    int ran = random.Next(0, 99);

                    if (ran % 2 == 0)
                    {


                        Console.WriteLine(ran);



                    }
                }
            }













        }
        private static List<int> CreateList(int size)
        {

            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(i);
            }
            return list;
        }
    }
}
