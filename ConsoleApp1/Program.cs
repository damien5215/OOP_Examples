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
            //LamdaEx.numbers();

            string[] unsorted = new string[] { "14", "3084193741082938", "11", "6", "2", 
                                               "31415926535897932384626433832795", "1", "8" };

            Collection.BigSort();

        }
    }
}

//FibConsole.MenuFunction();

//int[] arr = { 17, 2, 34, 48, 25 };
//Bubble bubble1 = new Bubble();
//bubble1.Sort2(arr);
