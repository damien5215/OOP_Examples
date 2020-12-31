using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BubbleSteps
    {
        public int[] Sort2(int arr1Length, int[] arr2) 
        {
            int x1;
            int x2;

            for (int i = 0; i < arr1Length - 1; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    Console.Write(arr2[j] + " ");
                }
                Console.Write("\n" + "\n");

                if (arr2[i] > arr2[i + 1])
                {
                    x1 = arr2[i];
                    x2 = arr2[i + 1];
                    arr2[i] = x2;
                    arr2[i + 1] = x1;
                }
            }

            for (int j = 0; j < arr2.Length; j++)
            {
                Console.Write(arr2[j] + " ");
            }
            Console.Write("\n" + "\n");

            return arr2;
        }

        public int[] Sort(int[] arr1)
        {

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1 = Sort2((arr1.Length - i), arr1);
                Console.Write("\n");
            }

            return arr1;
        }
    }
}

//int[] arr = { 4, 2, 3, 1 };
//int[] arr = { 3, 1, 6, 2 };
//Bubble bubble1 = new Bubble();
//BubbleSteps bubble1 = new BubbleSteps();
//bubble1.Sort(arr);