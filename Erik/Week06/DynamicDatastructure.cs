using System;


namespace Erik.Week06
{
    public class DynamicDatastructure
    {
        public static void Start()
        {
            Random randomNumber = new Random();
            List<int> randomList = new List<int>();

            for (int i = 0; i < 151; i++)
            {
                randomList.Add(randomNumber.Next(1, 101));
            }

            for (int i = 0; i < randomList.Count; i++)
            {
                Console.WriteLine("{0}. is {1}", i, randomList[i]);
            }
            int counter = 0;

            foreach (int Elements in randomList)
            {
                if (Elements % 2 == 0)
                {
                    counter++;
                }
                else
                {
                    randomList.Remove(Elements);
                    Console.WriteLine(randomList);
                }
            }
            Console.WriteLine(counter);
        }
    }
}
