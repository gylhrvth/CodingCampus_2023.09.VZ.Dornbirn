using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class TryCatchFinally
    {
        public static void Start()
        {
            Console.WriteLine("Enter a number!");
            string userinput = Console.ReadLine();



            try
            {
                int userInputAsInt = int.Parse(userinput);
            }
            catch(FormatException)
            {
                Console.WriteLine("Format Exception, please enter the correct type next time!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception, the number was too long or too short for an int32!");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Argument Null Exception, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }
        }
    }
}
