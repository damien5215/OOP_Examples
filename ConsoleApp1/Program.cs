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
            //FibConsole.MenuFunction();

            int[] arr = {4, 2, 3, 1 };
            //int[] arr = { 3, 2, 6, 1 };
            Bubble bubble1 = new Bubble();
            //bubble1.Sort1(arr);
            bubble1.Sort2(arr);
        }
    }
}

