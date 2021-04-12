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
            int[] array1 = new int[] { 1, 3, 5, 1, 1, 9 };
            int[] array2 = new int[] { 1, 3, 5, 8, 1, 9 };

            SequenceDetector SD2 = new SequenceDetector();
            bool result2 = SD2.Scan(array1);
            Console.WriteLine(result2);
            Console.WriteLine(SD2.Description + "\n" + "\n");

            SequenceDetector SD1 = new RepeatDetector();
            bool result = SD1.Scan(array1);
            Console.WriteLine(result);
            Console.WriteLine(SD1.Description + "\n" + "\n");

            result = SD1.Scan(array2);
            Console.WriteLine(result);
            Console.WriteLine(SD1.Description + "\n");
        }
    }
}

//FibConsole.MenuFunction();
