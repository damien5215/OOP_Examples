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
            int[] arr0 = {2, 3, 1};
            int[] arr1 = new int[arr0.Length]; //= {1, 2, 3};

            int[] arr2 = {0, 0, 0};
            int[] arr3 = {0, 0, 0};

            for (int i = 0; i < arr0.Length; i++) 
            {
                arr1[i] = i + 1;
            }

            for (int i = 0; i < arr0.Length; i++) 
            {
                arr2[i] = Array.IndexOf(arr0, arr1[i]) + 1;
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = Array.IndexOf(arr0, arr2[i]) + 1;
                Console.Write(arr3[i] + " ");
            }
        }
    }
}

//FibConsole.MenuFunction();

//FizzBuzz.PrintFizzBuzz(31);
//HackerRank.PrintStaircase(6);