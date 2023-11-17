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

            


            for (int i = 0; i < values.Count; i++)
            {

                    int ran = random.Next(0, 99);

                    if (ran % 2 == 0)
                    {


                        Console.WriteLine(ran);



                    }
            }
        }
        private static List<int> CreateList(int size)
        {
            
            List<int> list = new List<int>();
            for (int j = 0; j <= 10; j++)
            { 
                for (int i = 0; i < size; i++)
                {
                    list.Add(i);
                }

            }
            
            return list;
        }
    }
}
