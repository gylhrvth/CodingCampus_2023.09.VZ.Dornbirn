namespace Fabian.Week06
{
    public class Permutation
    {
        public static void Start()
        {
            List<string> list = new() {"A", "B", "C", "D" };
            Console.WriteLine("Permutations:");
            PrintPermutationList(list, 0, list.Count);
        }
        public static void PrintListPermutation(List<string> list)
        {
           
            foreach (string i in list)
            {
                Console.Write(i);

            }
            Console.WriteLine();
        }
        public static void PrintPermutationList(List<string> list, int startIndex, int endIndex)
        {
            if(startIndex == endIndex) { PrintListPermutation(list); }

            for (int i = startIndex; i < endIndex; i++)
            {
                (list[startIndex], list[i]) = (list[i], list[startIndex]);
                PrintPermutationList(list, startIndex + 1, endIndex);
                (list[startIndex], list[i]) = (list[i], list[startIndex]);
            }
                                           
        }  
    }
}
