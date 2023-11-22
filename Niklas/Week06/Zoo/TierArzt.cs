namespace Niklas.Week06.Zoo
{
    internal class TierArzt
    {
        private string _name;
        private int _HealedAnimals;
        private List<Animal> _AnimalsList;

        public int HealedAnimals
        {
            get => _HealedAnimals;

            set
            {
                _HealedAnimals = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public TierArzt(string name)
        {
            _name = name;
        }

        public static int[] BubbleSortAsc(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;

        }
    }
}
