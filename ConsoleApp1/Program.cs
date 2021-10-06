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

            // false
            //Luhn.CheckNo("1234123412341234");

            // true
            Luhn.CheckNo("4121144444444444");
        }
    }
}

