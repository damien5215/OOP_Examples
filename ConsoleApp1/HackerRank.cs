using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HackerRank
    {
        public static void Birthday(List<int> candles)
        {
            //List<int> candles = new List<int>() { 4, 2, 4, 4, 1 };

            int maxCandle = candles.Max();

            var results = from maxC in candles
                          where maxC == maxCandle
                          select maxC;

            Console.WriteLine(candles.Max() + "\n");
            Console.WriteLine(results.Count());
        }

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

        public static void equalArray(int stepNo)
        {
            
        }


    }
}

//List<int> candles = new List<int>() { 4, 2, 4, 4, 1 };
//HackerRank.Birthday(candles);

//HackerRank.PrintStaircase(4);
