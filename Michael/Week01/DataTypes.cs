﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week01
{
    public class DataTypes
    {

        
        public static void DataType()
        {

            Random rnd = new Random();


            int maxLeib = 10000;
            int maxNila = 10000;
            int maxSecret = 10000;
            int maxSqrt = 100;



            //sum from 20 to 50
            Console.WriteLine(" sum from 20 to 50 \n");

            int sum = 0;

            for (int i = 20; i <= 50; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);


            //product from 1 to 20
            Console.WriteLine("\n\n\n product from 1 to 20 \n");

            long product = 1;

            for (int i = 1; i <= 20; i++)
            {
                product *= i;
                Console.WriteLine("{0,2}! = {1,20}",i,product);
            }



            //0.1 steps from 0 to 100
            Console.WriteLine("\n\n\n 0.1 steps from 0 to 100\n");

            for (double count = 0; count <= 100; count += 0.1)
            {
                Console.WriteLine("{0:N1}", count);
            }



            //0.1 steps from 0 to 100, different formats
            Console.WriteLine("\n\n\n 0.1 steps from 0 to 100, different formats \n");

            for (double count = 0.1; count <= 100; count += 0.1)
            {
                Console.WriteLine($"{count,-3:0.0}", count);
                Console.WriteLine($"{count,7:0.00}", count);
                Console.WriteLine($"{count,-3:N1}", count);
                Console.WriteLine($"{count,7:N3}", count);
            }


            //0.1 steps from 0 to 100, percentage
            Console.WriteLine("\n\n\n 0.1 steps from 0 to 100, percentage \n");

            double counter = 0;
            while (counter <= 100)
            {
                Console.WriteLine($"Fortschritt: {counter,8:N1}%");
                counter += 0.1;
            }

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"{i} , {i / 5} , {i / 5.0}");
            }


            Console.WriteLine("\n");



            // pi via leibniz
            Console.WriteLine("\n\n\n pi via leibniz \n");

            double piLeib = 0;

            for (int i = 0; i < maxLeib; i++)
            {
                piLeib += Math.Pow(-1, i) * 4 / (2 * i + 1);
            }

            Console.WriteLine($"Pi with Leibniz: {piLeib}");


            Console.WriteLine("\n");



            //pi via nilakantha
            Console.WriteLine("\n\n\n pi via nilakantha \n");

            double piNila = 3;

            for (int i = 0; i < maxNila; i++)
            {
                piNila += Math.Pow(-1, i) * 4 / ((2 * i + 2) * (2 * i + 3) * (2 * i + 4));
            }

            Console.WriteLine($"Pi with Nilakantha: {piNila}");


            Console.WriteLine("\n");




            //secret series
            Console.WriteLine("\n\n\n secret series \n");

            double secretSum = 1.0;

            for (int i = 0; i < maxSecret; i++)
            {
                secretSum = (secretSum / 2) + (1 / secretSum);
            }

            Console.WriteLine($"The series gets close to: {secretSum} , which is sqrt(2)");


            Console.WriteLine("\n");



            //sqrt approx
            Console.WriteLine("\n\n\n sqrt approx \n");

            double root = rnd.Next(10000);
            double max = root;
            double min = 0;
            double average = (max + min) / 2;
            double square = 0;

            for (int i = 0; i < maxSqrt; i++)
            {
                average = (max + min) / 2;
                square = Math.Pow(average, 2);

                if (square > root)
                {
                    max = average;
                }
                else
                {
                    min = average;
                }

                //Console.WriteLine($"current estimate: {average,10:N4} \nreal solution: {Math.Sqrt(root),13:N4} \nerror in %: {((average - Math.Sqrt(root)) / Math.Sqrt(root)) * 100,15:N4}% \n");

            }

            Console.WriteLine($"The root of {root} is approximately {average} according to Heron.");


            Console.WriteLine("\n");


            Console.WriteLine($"test for the number {1297419,13}");

            root = 1297419;
            max = root;
            min = 0;
            average = (max + min) / 2;
            square = 0;

            int j = 0;
            while (Math.Abs(((average - Math.Sqrt(root)) / Math.Sqrt(root))) >= 0.0001)
            {
                average = (max + min) / 2;
                square = Math.Pow(average, 2);

                if (square > root)
                {
                    max = average;
                }
                else
                {
                    min = average;
                }

                j++;
            }

            Console.WriteLine($"current value: {average,18:N5} \ncorrect value: {Math.Sqrt(root),18:N5} \nerror in %: {Math.Abs(((average - Math.Sqrt(root)) / Math.Sqrt(root)) * 100),20:N5}% \nnach {j} Durchläufen");
        }
    }
}
