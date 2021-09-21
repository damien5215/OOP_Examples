using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Loops
    {
        public void ExWhile(int loopVariable)
        {
            string output = "This is a test!";
            int i = 0;

            while (i < loopVariable) 
            {
                Console.WriteLine(loopVariable + " - " + output);
                loopVariable--;
            }
        }

        public void ExDoWhile(int loopVariable)
        {
            string output = "This is a test! (Do While)";
            int i = 0;

            do
            {
                Console.WriteLine(loopVariable + " - " + output);
                loopVariable--;
            }
            while (i < loopVariable) ;
        }

    }
}
