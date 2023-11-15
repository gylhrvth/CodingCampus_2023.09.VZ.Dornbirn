using System;
using David.Week06.PersonExample;
namespace David.Week06.KurseTrainer
{
	public class KurseUndTrainerExample
	{
		public static void Start()
		{

			Person p1 = new Person("David", 35, 42);

            KurseUndTrainer K1 = new KurseUndTrainer("Software Developer", "26. 09. 2023", "€ 7.850,-", 500, p1);

            Console.WriteLine(K1);

          
        }
	}
}

