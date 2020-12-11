using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Room
    {
        private int _noOfWalls;

        // auto-property example + set default value 
        public int NoOfWalls { get; private set; } = 4;


        //public int noOfWalls
        //{
        //    get
        //    {
        //        return _noOfWalls;
        //    }
        //    private set 
        //    {
        //        _noOfWalls = value;
        //    }
        //}
    }
}

//Room room1 = new Room();
//Console.WriteLine(room1.NoOfWalls);
