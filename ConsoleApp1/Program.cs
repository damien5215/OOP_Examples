using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 50;

            Console.WriteLine("");
            Console.WriteLine("The " + n1 + "th term of the fibonacci sequence is: " + Fib1.Fib(n1));
            Console.WriteLine("");
        }
    }
}

// n = 46, result = 1836311903
// n = 47, result = 2971215073

// Signed 32-bit integer goes up to 2,147,483,647