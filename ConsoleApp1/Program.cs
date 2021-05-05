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
            //FibConsole.MenuFunction();

            string input = "one two. three. four five six. seven. eight nine.";

            Editor edit = new Editor();

            Console.WriteLine(edit.WordCount(input));
        }
    }
}

//FibConsole.MenuFunction();
