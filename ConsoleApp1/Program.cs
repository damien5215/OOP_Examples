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
            //LamdaEx.numbers();

            int[] arr = { 17, 2, 34, 48, 25, 6 };

            Console.Write("Before SORT = ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }


            int[] arr2 = MergeSort.mergeSort(arr);

            Console.Write("After SORT = ");
            foreach (int num in arr2)
            {
                Console.Write(num + " ");
            }
            Console.Write("\n");

        }
    }
}

//FibConsole.MenuFunction();

//int[] arr = { 17, 2, 34, 48, 25 };
//Bubble bubble1 = new Bubble();
//bubble1.Sort2(arr);
