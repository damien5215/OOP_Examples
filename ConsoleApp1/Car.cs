using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public string model;
        public string colour;
        public int year;

        public Car(string modelName, string modelColour, int modelYear) 
        {
            model = modelName;
            colour = modelColour;
            year  = modelYear;
        }
    }
}

//Car Ford = new Car("Mustang", "Red", 1969);

//Console.WriteLine(Ford.model + "\n" + 
//                  Ford.colour + "\n" + 
//                  Ford.year  + "\n");
