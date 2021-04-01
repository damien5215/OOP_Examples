using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7; int b = 9; int c = 7;
            MathOps math1 = new MathOps();

            Console.WriteLine("Square Function " + c + " = " + 
                               math1.MathOperation(c));

            Console.WriteLine("Multiply Function (" + a + ", " + b + ") = " + 
                              math1.MathOperation(a, b));
        }
    }
}

//FibConsole.MenuFunction();
