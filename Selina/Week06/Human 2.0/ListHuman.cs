namespace Selina.Week06.Human_2._0
{
    public class ListHuman
    {
        public static void Start()
        {
            List<HumanExample2> personList = new List<HumanExample2>();

            SetListOfHuman("Selina", 17, 45, 152, personList);
            SetListOfHuman("Manuel", 14, 60, 166, personList);
            SetListOfHuman("Sandro", 35, 70, 180, personList);
            SetListOfHuman("David", 27, 80, 175, personList);
            PrintList(personList);


            int smallestSize = SmallestSize(HumanExample2 person);
            Console.WriteLine();
            Console.WriteLine(smallestSize);


        }
        public static List<HumanExample2> SetListOfHuman(string name, int age, int weigth, int size, List<HumanExample2> personList)
        {
            HumanExample2 person = new HumanExample2(name, age, weigth, size);
            personList.Add(person);

            return personList;
        }
        public static int SmallestSize(List<HumanExample2> personList)
        {
            int tallest = personList.Count;

            foreach (person in personList)
            {
                if (person._Size > tallest[person])
                {
                    tallest = person;
                }
            }
            return tallest;
        }
        public static void PrintList(List<HumanExample2> listRandomNumbers)
        {
            foreach (HumanExample2 p in listRandomNumbers)
            {
                Console.Write($"{p,4}");
            }
        }
    }
}
