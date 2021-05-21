using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Staircase
    {
        public static void PrintStaircase(int stepNo)
        {
            string result = "";

            for (int i = 1; i < stepNo + 1; i++) 
            {
                for (int j = 0; j < (stepNo - i); j++)
                {
                    result += "_";
                }

                for (int k = 0; k < (i); k++)
                {
                    result += "#";
                }
                Console.WriteLine(result);
                result = "";
            }
        }
    }
}

//Staircase.PrintStaircase(4);
