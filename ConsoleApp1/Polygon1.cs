using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Polygon1
    {
        public readonly int NumSides;

        public Polygon1(int numSides) 
        {
            NumSides = numSides;
        }
    }

    class Square1 : Polygon1 
    {
        public readonly int SideLength;

        public Square1(int sideLength) : base(4) 
        {
            SideLength = sideLength;
        }
    }
}

//Square1 square1 = new Square1(5);
//Console.WriteLine(square1.NumSides);
//Console.WriteLine(square1.SideLength);