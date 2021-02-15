using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MergeSort
    {
        // https://www.c-sharpcorner.com/blogs/a-simple-merge-sort-implementation-c-sharp
        public static int[] sort(int[] input) 
        {
            //List<int> digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> inputList = input.ToList(); //new List<int>();

            List<int> Left;
            List<int> Right;

            List<int> Result = new List<int>(input.Length);

            if (input.Length <= 1)
                return input;

            int midPoint = input.Length / 2;
            Left = new List<int>(midPoint);

            return input;
        }

        public static int[] mergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
                return array;
            
            // The exact midpoint of our array will represent our 'left' array 
            int midPoint = array.Length / 2;
            left = new int[midPoint];

            //if array has an even no. of elements, the left and right array will have the same no. 
            //if array has an odd no. of elements, the right array will have 1 more element than the left element
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            else
                right = new int[midPoint + 1];
            
            //populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];

            //populate right array. 
            //start index from midpoint    
            int x = 0;
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }

            Console.WriteLine("\n");
            foreach (int num in left)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("\n");
            foreach (int num in right)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");


            //Recursively sort the left and right array
            left = mergeSort(left);
            right = mergeSort(right);

            //Merge our two sorted arrays
            result = merge(left, right);
            
            return result;
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }

    }
}

//int[] arr = { 17, 2, 34, 48, 25 };
//int[] arr2 = MergeSort.mergeSort(arr);

//foreach(int num in arr2) 
//{
//    Console.WriteLine(num);
//}