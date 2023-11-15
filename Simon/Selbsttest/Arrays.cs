using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Selbsttest;
internal class Arrays
{
    public static Random random = new Random();
    public static void Start()
    {
        int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };

        int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };

        int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

        Console.WriteLine(FirstAndLast(arr));
        Console.WriteLine(FirstAndLast(arr2));
        Console.WriteLine(FirstAndLast(arr3));

        PrintMyResult("Minimum", GetMinArr(arr));
        PrintMyResult("Maximum", GetMaxArr(arr2));
        PrintMyResult("Average", GetAvgArr(arr3));

        int[] arrx = CreateArr1(10);

        Console.WriteLine($"[{string.Join(", ", arrx)}]");

        foreach (int i in arrx) { Console.WriteLine(i); }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arrx[i]);
        }

        Console.WriteLine($"[{string.Join(", ", CreateRandomArr(10))}]");

        PrintArr(Bubblesort(CreateRandomArr(100), false));




    }

    public static string FirstAndLast(int[] arr)
    {
        return "First: " + arr[0] + ", Last: " + arr[arr.Length - 1];
    }

    public static int GetMinArr(int[] arr)
    {
        int min = int.MaxValue;
        foreach (int i in arr)
        {
            if (i < min)
            {
                min = i;
            }
        }
        return min;
    }

    public static int GetMaxArr(int[] arr)
    {
        int max = int.MinValue;
        foreach (int i in arr)
        {
            if (i > max)
            {
                max = i;
            }
        }
        return max;
    }

    public static int GetAvgArr(int[] arr)
    {
        int avg = 0;
        foreach (int i in arr)
        {
            avg += i;
        }
        avg /= arr.Length;
        return avg;
    }

    public static void PrintMyResult(string value, int arr)
    {

        Console.WriteLine(value + ": " + arr);
    }
    public static int[] CreateArr1(int size)
    {
        int[] arr = new int[size + 1];
        for (int i = 0; i <= size; i++)
        {
            arr[i] = i;
        }
        return arr;
    }

    public static int[] CreateRandomArr(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(size + 1);
        }
        return arr;
    }
    public static int[] Bubblesort(int[] arr, bool asc)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length-i-1; j++)
            {
                if (asc)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                    }
                }
                else
                {
                    if (arr[j] < arr[j + 1])
                    {
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                    }
                }

            }
        }
        return arr;
    }

    public static void PrintArr(int[] arr)
    {
        Console.WriteLine($"[{string.Join(", ", arr)}]");
    }




}

