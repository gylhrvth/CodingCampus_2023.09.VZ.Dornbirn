namespace Fabian.Week06
{
    public class LinkedLists
    {
        private static Random rnd = new();
        public static void Start()
        {
            LinkedList<int> list = CreateLinkedListRandom(20);
            PrintList(list);
            Console.WriteLine("\n");
            Console.WriteLine("Count even numbers: " +  CountEvenNums(list));
            Console.WriteLine("smallest number: " +  GetSmallest(list));
            Console.WriteLine("biggest number: " +  GetBiggest(list));
            Console.WriteLine("\n");
            Console.Write("Sorted list: ");           
            PrintList(SortLinkedList(list, false));
        }

        public static void PrintList(LinkedList<int> list)
        {
            bool first = true;
            foreach (int i in list)
            {
                if(!first) Console.Write(", " + i);
                else Console.Write(i);
                first = false;
            }
        }
        public static LinkedList<int> CreateLinkedListRandom(int size)
        {
            LinkedList<int> list = new();

            for (int i = 0; i < size; i++)
            {
                list.AddLast(rnd.Next(100));
            }
            return list;
        }

        public static int CountEvenNums(LinkedList<int> list)
        {
            int count = 0;
            foreach (int i in list)
            {
                if(i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static int GetSmallest(LinkedList<int> list)
        {
            int min = list.ElementAt(0);
            foreach (int i in list)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        public static int GetBiggest(LinkedList<int> list)
        {
            int max = list.ElementAt(0);
            foreach (int i in list)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        public static LinkedList<int> SortLinkedList(LinkedList<int> list, bool asc)
        {
            for (int i = 0; i < list.Count; i++)
            {
                LinkedListNode<int> currentNode = list.First;
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    LinkedListNode<int> nextNode = currentNode.Next;
                    if ((asc && currentNode.Value > nextNode.Value) || (!asc && currentNode.Value < nextNode.Value))
                    {
                        (currentNode.Value, nextNode.Value) = (nextNode.Value, currentNode.Value);
                    }
                    currentNode = nextNode;
                }
            }

            return list;
        }
    }
}
