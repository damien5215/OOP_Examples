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
            //int[] arr = { 3, 1, 6, 2 };
            //Bubble bubble1 = new Bubble();
            BubbleSteps bubble1 = new BubbleSteps();
            bubble1.Sort(arr);
        }
    }
}

