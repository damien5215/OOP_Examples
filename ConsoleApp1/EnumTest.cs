using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EnumTest
    {
        public enum IntensityLevel
        {
            Low = 1,
            Medium = 2,
            High = 3
        }

    }
}

//var results = Enum.GetValues(typeof(EnumTest.IntensityLevel))
//    .Cast<EnumTest.IntensityLevel>()
//    .Select(il => new { id = (int)il, name = il.ToString() })
//    .ToList();

//Console.WriteLine(results[0]);
//Console.WriteLine(results[1]);
//Console.WriteLine(results[2]);
