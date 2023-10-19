using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week03
{
    internal class Arrays
    {
        public static void StartArrays()
        {
            //CreateArray(10);
            //CreateArray(5);
            //CreateArray2(10);
            //RandomNumberArray();
            //RandomNumberArrayCount();
            //RandomNumberArraySumme();
            Array2d();
        }

        //Aufgabe: Number Array
        public static int[] CreateArray(int size)
        {
            int[] Numbers = new int[size];



            for (int i = 0; i < Numbers.Length; i++)
            {



                Numbers[i] = i;
              
            }

            
            return Numbers;
 

        }

        public static int[] CreateArray2(int size)
        {
            int[] Numbers = new int[size];
            int a = Numbers.Length;

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = a;
                a--;
                
            }

        

            return Numbers;

        }

        //Aufgabe: Kopie


        //nummer bei Datei/neue

   

        //Aufgabe: Random Number Array

        public static void RandomNumberArray()
        {
            int[] Platz = new int[10];

            Random rand = new Random();

          
            /*
            for (int i = 0 ;i < Platz.Length ;i++)
            {
                int RandomNumber = rand.Next(100);

                Platz[i] = RandomNumber;

                Console.WriteLine(i + " = " + Platz[i]);
            }

            foreach (int stelle in Platz)
            {

                int RandomNumber = rand.Next(100);

                Platz[stelle] = RandomNumber;

                Console.WriteLine(stelle + " = " + Platz[stelle]); // stelle bei foreach ist immer 0

            }
              
            */

            for (int i = 0; i < Platz.Length; i++)
            {

                int RandomNumber = rand.Next(100);

                Platz[i] = RandomNumber;

                Console.WriteLine("[{0}]", string.Join(" = ", i, RandomNumber));

            }

            Console.WriteLine();

            Console.WriteLine(Platz[1]);
            Console.WriteLine(Platz[4]);
            Console.WriteLine(Platz[9]);

            Console.WriteLine("----");

            for (int i = 0; i < Platz.Length;i+= 2)
            {

                Console.WriteLine(Platz[i]);

            }

            Console.WriteLine("-------------");

            int[] crazynumbers = new int[10];

            foreach(int element in crazynumbers) 
            {
                int newNumber = rand.Next(-50,50);

                crazynumbers[element] = newNumber;

                Console.WriteLine(crazynumbers[element]);
            }

        }


        public static void RandomNumberArrayCount()
        {

            Random rand = new Random();


            int[] ArraysCount = new int[100];

            foreach (int element in ArraysCount)
            {
                int randomnumber = rand.Next(1, 100);

                ArraysCount[element] = randomnumber;

                if (randomnumber >= 30)
                {
                    Console.WriteLine("Ist über dreisig: " + ArraysCount[element]);
                }
            }
        }

        public static void RandomNumberArraySumme()
        {

            Random rand = new Random();


            int[] ArraysCount = new int[100];

            int result = 0;

            foreach (int element in ArraysCount)
            {
                int randomnumber = rand.Next(1, 100);

                result += randomnumber;

                ArraysCount[element] = randomnumber;

            }

            Console.WriteLine("Result is: " + result);
        }

        public static void Array2d()
        {
            Random rand = new Random();

            //create array 2d
            int[][] arr2d = new int[4][];


            for (int row = 0; row < arr2d.Length; row++)
            {
                //Random: arr2D[row] = new int[r.Next(0, 10)];
                arr2d[row] = new int[4];
            }

            bool GameOver = false;

            Console.WriteLine("Willkommen zum Feld errate Spiel!");
            Console.WriteLine("Wähle eine 1 und siehe was sich dahinter versteckt, du darfst keine 7 finden! ;(");

            while(GameOver == false)
            {

                Console.WriteLine();

                Console.WriteLine("Gib die Zeile ein 0 bis 3");
                int guessrow = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Gib die Stelle der Spalte ein 0 bis 3");
                int guessCol = Convert.ToInt32(Console.ReadLine());

                arr2d[guessrow][guessCol] = 1;

                int computerguess = arr2d[rand.Next(4)][rand.Next(4)];

                if(arr2d[guessrow][guessCol] == computerguess)
                {
                    Console.WriteLine("Verloren..");
                    Console.WriteLine();

                    for (int row = 0; row < arr2d.Length; row++)
                    {
                        for (int col = 0; col < arr2d[row].Length; col++)
                        {
                            Console.Write(arr2d[row][col] + " ");
                        }
                        Console.WriteLine();
                    }

                    computerguess = 7;

                    break;
                }


                //Print
                for (int row = 0; row < arr2d.Length; row++)
                {
                    for (int col = 0; col < arr2d[row].Length; col++)
                    {
                        Console.Write(arr2d[row][col] + " ");
                    }
                    Console.WriteLine();
                }
       
            }
        }
    }
}
