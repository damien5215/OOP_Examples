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
        public string color;   // colour
        public int year;

        public Car(string modelName, string modelColor, int modelYear) 
        {
            model = modelName;
            color = modelColor;
            year  = modelYear;
        }
    }
}

//Car Ford = new Car("Mustang", "Red", 1969);

//Console.WriteLine(Ford.model + "\n" + 
//                  Ford.color + "\n" + 
//                  Ford.year  + "\n");
