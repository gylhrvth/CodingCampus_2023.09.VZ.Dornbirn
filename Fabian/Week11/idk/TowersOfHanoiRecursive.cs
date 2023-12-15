namespace Fabian.Week11.idk
{
    internal class TowersOfHanoiRecursive
    {
        public static void Start()
        {
            Console.Write("Enter the amount of discs: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Hanoi('A', 'C', 'B', n);
        }

        private static void Hanoi(char source, char destination, char temporary, int n)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disc {n} from {source} to {destination}");
            }
            else
            {
                Hanoi(source, temporary, destination, n - 1);
                Console.WriteLine($"Move disc {n} from {source} to {destination}");
                Hanoi(temporary, destination, source, n - 1);
            }

        }
    }


}
