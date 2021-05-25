using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HackerRank
    {
        public static void Birthday(List<int> candles)
        {
            //List<int> candles = new List<int>() { 4, 2, 4, 4, 1 };

            int maxCandle = candles.Max();

            var results = from maxC in candles
                          where maxC == maxCandle
                          select maxC;

            Console.WriteLine(candles.Max() + "\n");
            Console.WriteLine(results.Count());
        }

        public static void PrintStaircase(int stepNo)
        {
            string result = "";

            for (int i = 1; i < stepNo + 1; i++)
            {
                for (int j = 0; j < (stepNo - i); j++)
                {
                    result += "_";
                }

                for (int k = 0; k < (i); k++)
                {
                    result += "#";
                }
                Console.WriteLine(result);
                result = "";
            }
        }

        public static void equalArray(List<int> nums)
        {
            int count1 = 0;
            int count2 = 0;
            int result = 0;

            //List<int> nums = new List<int>() { 5, 3, 7, 7, 12, 7 };

            int[] arr = nums.ToArray();
            var nums2 = nums.OrderBy(a => a);
            arr = nums2.ToArray();

            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            foreach (int i in nums2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count1++;

                    if (count1 > count2)
                    {
                        count2 = count1;
                        result = arr[i];
                    }
                }

                else
                {
                    count1 = 0;
                }
            }

            var results = from a in nums
                          where a == result
                          select a;

            Console.WriteLine("Array Length = " + nums.Count() + "\n");
            Console.WriteLine("Most Frequent Number = " + result + "\n");
            Console.WriteLine("Number of Repeats = " + results.Count() + "\n");
        }

        static int[] permutationEquation(int[] p)
        {
            // int[] p = {2, 3, 1};
            int[] arr0 = p;
            int[] arr1 = new int[arr0.Length]; // {1, 2, 3};

            int[] arr2 = new int[arr0.Length]; // {0, 0, 0};
            int[] arr3 = new int[arr0.Length]; // {0, 0, 0};

            for (int i = 0; i < arr0.Length; i++)
            {
                arr1[i] = i + 1;
            }

            for (int i = 0; i < arr0.Length; i++)
            {
                arr2[i] = Array.IndexOf(arr0, arr1[i]) + 1;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = Array.IndexOf(arr0, arr2[i]) + 1;
                //Console.WriteLine(arr3[i]);
            }
            return arr3;
        }

    }
}

//List<int> candles = new List<int>() { 4, 2, 4, 4, 1 };
//HackerRank.Birthday(candles);

//HackerRank.PrintStaircase(4);
