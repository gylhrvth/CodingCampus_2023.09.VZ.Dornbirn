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
		}


        public static int Add(int a, int b)
		{
			int result = a + b;

			return result;
		}

    }
}

