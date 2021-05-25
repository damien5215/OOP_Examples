using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0;
            int count2 = 0;
            int result = 0;

            List<int> nums = new List<int>() {5, 3, 7, 7, 12, 7};

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
    }
}

//FibConsole.MenuFunction();

//FizzBuzz.PrintFizzBuzz(31);
//HackerRank.PrintStaircase(6);


//foreach (int i in nums)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine("\n");

//foreach (int i in nums2)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine("\n");