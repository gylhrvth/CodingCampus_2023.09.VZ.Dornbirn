using System;
namespace Gyula.Week02
{
	public class FunctionWithReturn
	{
		public static void Start()
		{
			Console.WriteLine(Add(3, 2));

			int c = Add(5, 4);
			Console.WriteLine(c);

			Console.WriteLine(Summ());
		}


        public static int Add(int a, int b)
		{
			int result = a + b;

			return result;
		}


		public static int Summ()
		{
			int result = 0;
			for (int i = 20; i <= 50; i++)
			{
				result += i;
			}
			return result;
		}
    }
}

