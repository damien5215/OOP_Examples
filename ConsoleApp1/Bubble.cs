using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class prints the array to the console, before and after the sort method

// Sort recieves an array of integers and prints the array
// then in a for-loop, the array and it's length is sent to the method "SortMain"
// SortMain uses a for-loop which compares two adjacent elements in the array
// if the first number is greater, the values are swapped
// this results in the largest number in the array being moved to the "top" of the array
// this new array is loaded to the previous array and SortMain is called again
// this time the "array size integer" is decremented and the second largest value is moved
// this continues until the entire array is ordered and "Sort" returns the array

namespace ConsoleApp1
{
    class Bubble
    {
        private int[] SortMain(int arr1Length, int[] arr2)
        {
            int x1;
            int x2;

            for (int i = 0; i < arr1Length - 1; i++)
            {
                if (arr2[i] > arr2[i + 1])
                {
                    x1 = arr2[i];
                    x2 = arr2[i + 1];
                    arr2[i] = x2;
                    arr2[i + 1] = x1;
                }
            }
            return arr2;
        }

        public int[] Sort(int[] arr1)
        {
            printArray(arr1); 

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1 = SortMain((arr1.Length - i), arr1);
            }

            printArray(arr1);
            return arr1;
        }

        public static void printArray(int[] arr3) 
        {
            for (int j = 0; j < arr3.Length; j++)
            {
                Console.Write(arr3[j] + " ");
            }
            Console.Write("\n" + "\n");
        }
    }
}

//int[] arr = { 7, 2, 4, 8, 1, 5 };
//Bubble bubble2 = new Bubble();
//bubble2.Sort(arr);