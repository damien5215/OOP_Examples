using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class contains the same code as "bubble.cs" but it prints the array to the console, 
// at all stages during the "bubble sort" calculation.

namespace ConsoleApp1
{
    class Bubble2
    {
        public int[] SortMain(int arr1Length, int[] arr2)
        {
            int x1;
            int x2;

            for (int i = 0; i < arr1Length - 1; i++)
            {
                Bubble.printArray(arr2);

                if (arr2[i] > arr2[i + 1])
                {
                    x1 = arr2[i];
                    x2 = arr2[i + 1];
                    arr2[i] = x2;
                    arr2[i + 1] = x1;
                }
            }
            Bubble.printArray(arr2);
            return arr2;
        }

        public int[] Sort(int[] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1 = SortMain((arr1.Length - i), arr1);
                Console.Write("\n");
            }

            return arr1;
        }
    }
}

//int[] arr = { 7, 2, 4, 8, 1, 5 };
//Bubble2 bubble = new Bubble2();
//bubble.Sort(arr);