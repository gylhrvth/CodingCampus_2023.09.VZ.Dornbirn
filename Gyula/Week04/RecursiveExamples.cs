using System;
namespace Gyula.Week04
{
	public class RecursiveExamples
	{
		public static void Start()
		{
			int x = 5;
			Console.WriteLine("{0}! = {1}", x, FaktRecursive(x, ""));
		}

		public static int SumFirst(int n)
		{
			int result = 0;
			for (int x = 1; x <= n; ++x)
			{
				result += x;
			}
			return result;
		}

        public static int SumFirstRecursive(int context)
        {
			if (context == 0) { return 0; }
			return context + SumFirstRecursive(context - 1);
        }

        public static int FaktRecursive(int context, string prefix)
        {
			Console.WriteLine("{0}FaktRecursive({1})", prefix, context);
            if (context == 1) { return 1; }
            int result = context * FaktRecursive(context - 1, prefix + "  ");
			Console.WriteLine("{0}FaktRecursive({1}) has the result: {2}", prefix, context, result);
            return result;
        }
    }
}

