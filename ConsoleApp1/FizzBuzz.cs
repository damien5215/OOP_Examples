using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FizzBuzz
    {
        public static void PrintFizzBuzz(int input)
        {
            for (int i = 1; i <= input; i++) 
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FIZZ BUZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else 
                { 
                    Console.WriteLine(i);
                }
            }
        }
    }
}

//FizzBuzz.PrintFizzBuzz(31); 
