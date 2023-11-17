namespace Selina.Week06.Human_2._0
{
    public class ListHuman
    {
        public enum Sort
        {
            Size,
            Age,
            Name,
            Weight
        }

        public static void Start()
        {
            double resultHighOfAllPeople = 0;

            List<HumanExample2> personList = new List<HumanExample2>
            {
                new HumanExample2("Selina", 17, 45, 152),
                new HumanExample2("Manuel", 14, 60, 166),
                new HumanExample2("Sandro", 35, 70, 180),
                new HumanExample2("David", 27, 80, 175)
            };

            PrintList(personList);


            HumanExample2 smallestHuman = Smallest(personList);
            Console.WriteLine();
            Console.WriteLine("The smallest Person in class is: {0} with {1} cm.", smallestHuman.Name, smallestHuman.Size);

            HumanExample2 tallestHuman = Tallest(personList);
            Console.WriteLine();
            Console.WriteLine("The tallest Person in class is:  {0} with {1} cm.", tallestHuman.Name, tallestHuman.Size);

            HumanExample2 oldestHuman = Oldest(personList);
            Console.WriteLine();
            Console.WriteLine("The oldest Person in class is:   {0} with {1} years.", oldestHuman.Name, oldestHuman.Age);

            HumanExample2 youngestHuman = Youngest(personList);
            Console.WriteLine();
            Console.WriteLine("The youngest Person in class is: {0} with {1} years.", youngestHuman.Name, youngestHuman.Age);

            HumanExample2 lightestHuman = Lightest(personList);
            Console.WriteLine();
            Console.WriteLine("The lightest Person in class is: {0} with {1} kg.", lightestHuman.Name, lightestHuman.Weigth);

            HumanExample2 heaviestHuman = Heaviest(personList);
            Console.WriteLine();
            Console.WriteLine("The heaviest Person in class is: {0} with {1} kg.", heaviestHuman.Name, heaviestHuman.Weigth);

            resultHighOfAllPeople = HighOfAllPeople(personList);
            Console.WriteLine();
            Console.WriteLine("High of all People: " + resultHighOfAllPeople + " cm");

            resultHighOfAllPeople = AgeOfAllPeople(personList);
            Console.WriteLine();
            Console.WriteLine("Age of all People: " + resultHighOfAllPeople + " years");

            resultHighOfAllPeople = WeightOfAllPeople(personList);
            Console.WriteLine();
            Console.WriteLine("Weight of all People: " + resultHighOfAllPeople + " kg");

           

        }
       
      
        public static double WeightOfAllPeople(List<HumanExample2> personList)
        {
            double result = 0;

            foreach (HumanExample2 person in personList)
            {
                result += person.Weigth;
            }
            result /= personList.Count;

            return result;
        }
        public static double AgeOfAllPeople(List<HumanExample2> personList)
        {
            double result = 0;

            foreach (HumanExample2 person in personList)
            {
                result += person.Age;
            }
            result /= personList.Count;

            return result;
        }
        public static double HighOfAllPeople(List<HumanExample2> personList)
        { 
            double result = 0;
    
            foreach(HumanExample2 person in personList )
            {
                result += person.Size;
            }
            result /= personList.Count;

            return result;
        }
        public static HumanExample2 Smallest(List<HumanExample2> personList)
        {
            HumanExample2 smallestHuman = null;

            foreach (HumanExample2 person in personList)
            {
                if (smallestHuman == null || person.Size < smallestHuman.Size)
                {
                    smallestHuman = person;
                }
            }
            return smallestHuman;
        }
        public static HumanExample2 Tallest(List<HumanExample2> personList)
        {
            HumanExample2 tallestHuman = null;

            foreach (HumanExample2 person in personList)
            {
                if (tallestHuman == null || person.Size > tallestHuman.Size)
                {
                    tallestHuman = person;
                }
            }
            return tallestHuman;
        }
        public static HumanExample2 Oldest(List<HumanExample2> personList)
        {
            HumanExample2 oldest = null;

            foreach (HumanExample2 person in personList)
            {
                if (oldest == null || person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }
            return oldest;
        }
        public static HumanExample2 Youngest(List<HumanExample2> personList)
        {
            HumanExample2 youngest = null;

            foreach (HumanExample2 person in personList)
            {
                if (youngest == null || person.Age < youngest.Age)
                {
                    youngest = person;
                }
            }
            return youngest;
        }
        public static HumanExample2 Lightest(List<HumanExample2> personList)
        {
            HumanExample2 lightest = null;

            foreach (HumanExample2 person in personList)
            {
                if (lightest == null || person.Weigth < lightest.Weigth)
                {
                    lightest = person;
                }
            }
            return lightest;
        }
        public static HumanExample2 Heaviest(List<HumanExample2> personList)
        {
            HumanExample2 heaviest = null;

            foreach (HumanExample2 person in personList)
            {
                if (heaviest == null || person.Weigth > heaviest.Weigth)
                {
                    heaviest = person;
                }
            }
            return heaviest;
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
