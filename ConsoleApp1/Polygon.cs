using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Polygon
    {
        // Auto property example
        public int NumSides { get; private set; }

        public Polygon(int numSides)
        {
            NumSides = numSides;
        }
    }

    class Square : Polygon 
    {
        public double SideLength { get; private set; }

        public Square(double sideLength) : base(4) 
        {
            SideLength = sideLength;
        }

        // Computed property example
        public double Area => SideLength * SideLength;
    }
}

//Square square1 = new Square(3);
//Console.WriteLine("NumSides = " + square1.NumSides);
//Console.WriteLine("SideLength = " + square1.SideLength);
//Console.WriteLine("Area = " + square1.Area);
