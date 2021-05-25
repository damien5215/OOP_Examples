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
            //FibConsole.MenuFunction();

            int count1 = 0;
            int count2 = 0;
            int result = 0;

            List<int> nums = new List<int>() { 1, 2, 2, 3};

            int[] arr = nums.ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count1++;

                    if (count1 > count2)
                    {
                        count2 = count1;
                        //index = i;
                        result = arr[i];
                    }
                }

                else
                {
                    count1 = 0;
                }
            }
            Console.WriteLine(result);
        }
    }
}

//FibConsole.MenuFunction();

//FizzBuzz.PrintFizzBuzz(31);
//HackerRank.PrintStaircase(6);