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
            string s1 = "We promptly judged antique ivory buckles for the next prize";
            string s2 = "The quick brown fox jumps over the lazy dog";
            string s3 = "abcd efg hijk lmnop qrs tuv";
            string s4 = "abcd efg hijk lmnop qrs tuv wxyz";
            Pangrams.Pangram(s1);
            Pangrams.Pangram(s2);
            Pangrams.Pangram(s3);
            Pangrams.Pangram(s4);
        }
    }
}

//FibConsole.MenuFunction();
