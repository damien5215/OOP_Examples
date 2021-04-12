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
            Square square1 = new Square(3);
            Console.WriteLine("NumSides = " + square1.NumSides);
            Console.WriteLine("SideLength = " + square1.SideLength);
            Console.WriteLine("Area = " + square1.Area);

        }
    }
}

//FibConsole.MenuFunction();
