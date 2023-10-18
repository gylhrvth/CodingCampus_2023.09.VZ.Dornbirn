using System;
namespace David.Week04
{
    public class Day02
    {
        public static void Start()
        {

            //Console.WriteLine(Summe(5));
	    
	   Console.WriteLine(Fibo(5));
	        
	    // Faktorial(5);

        }

        public static int Summe(int sum)
        {
            if (sum == 0)
	        {
		        return 0;
		    }

	        return sum + Summe(sum -1); 
        
	    }

        public static int Faktorial(int context)
        {
            if (context == 1)
            {
                return 1;
            }
            else
            {
                int factorial = context * Faktorial(context - 1);

                Console.WriteLine(factorial);
                return factorial;
            }

        }

        public static int Fibo(int x)
        {

            if (x == 1 || x == 2)
            {
                return x = 0;
            }
            return x = ((x - 1) + (x - 2));
        }
    }

}


