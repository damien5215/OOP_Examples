using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Calculate nth Fibonacci number using memoization

// If the integer n is less than 2, it is returned. fib(0) = 0 and fib(1) = 1.
// Else, an array of doubles is created of size n and first two values of array are set to 0 and 1.
// n is incremented because array is zero-indexed.
// "n" and the "array" is passed to the recursive method, "calcFib".
// If the integer n is less than 2, it is returned. calcFib(0) = 0 and calcFib(1) = 1.
// Else If, array[n] is not 0 (value has already been calculated and stored), value is returned.
// Else, array[n] is calculated from the the previous two values.
// The array is built from the first two values.
// Once array[n] is calculated the value is returned.

// NOTE: n = 46, result = 1836311903 and n = 47, result = 2971215073
// Signed 32-bit integer, largest positive number is 2,147,483,647
// Changed fibArray[] to contain "double" therefore can compute fib numbers > n = 46 

namespace ConsoleApp1
{
    public class Fib1
    {
        public static double Fib(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else 
            {
                n++;
                double[] fibArray = new double[n];
                fibArray[0] = 0;
                fibArray[1] = 1;
                n--;
                return calcFib(n, fibArray);
            }
        }

        static double calcFib(int n, double[] fibArray)
        {
            if (n < 2)
            {
                return n;
            }
            else if (fibArray[n] != 0)
            {
                return fibArray[n];
            }
            else
            {
                fibArray[n] = calcFib(n - 1, fibArray) + calcFib(n - 2, fibArray);
                return fibArray[n];
            }
        }
    }
}

//int n1 = 46;

//Console.WriteLine("");
//Console.WriteLine("The " + n1 + "th term of the fibonacci sequence is: " + Fib1.Fib(n1));
//Console.WriteLine("");

