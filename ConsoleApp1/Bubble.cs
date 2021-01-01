using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class contains 2 main methods: "sort1" and "sort2"
// sort1 prints the array to the console, before and after the sort method
// sort2 prints the array to the console, at all stages during the calculation

// sort1 recieves an array of integers and prints the array
// then in a for-loop, the array and it's length is sent to the method "Sort1a"
// Sort1a uses a for-loop which compares two adjacent elements in the array
// if the first number is greater, the values are swapped
// this results in the largest number in the array being moved to the "top" of the array
// this new array is loaded to the previous array and Sort1a is called again
// this time the "array size integer" is decremented and the second largest value is moved
// this continues until the entire array is ordered and sort1 returns the array

namespace ConsoleApp1
{
    class Bubble
    {
        private int[] Sort1a(int arr1Length, int[] arr2)
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

        public int[] Sort1(int[] arr1)
        {
            printArray(arr1); 

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1 = Sort1a((arr1.Length - i), arr1);
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

        public int[] Sort2a(int arr1Length, int[] arr2)
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

        public int[] Sort2(int[] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1 = Sort2a((arr1.Length - i), arr1);
                Console.Write("\n");
            }
            return arr1;
        }
    }
}

//int[] arr = { 4, 2, 3, 1 };
//int[] arr = { 3, 2, 6, 1 };
//Bubble bubble1 = new Bubble();
//bubble1.Sort1(arr);
//bubble1.Sort2(arr);
