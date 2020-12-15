using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IUnaryOperation
    {
        double Perform(double value);
    }
    class Increment : IUnaryOperation
    {
        public double Perform(double value)
        {
            return (value + 1);
        }
    }
}

//Increment inc = new Increment();
//Console.WriteLine(inc.Perform(5));
