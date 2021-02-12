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

    }
}
