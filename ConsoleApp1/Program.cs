﻿using System;
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
            // FibConsole.MenuFunction();

            Loops loopObject = new Loops();
            loopObject.ExWhile(3);
            loopObject.ExDoWhile(4);
            loopObject.ExForWhile(3);
        }
    }
}

