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

        public static void getEnums1() 
        {
            foreach (var result in Enum.GetValues(typeof(EnumTest.IntensityLevel)))
            {
                Console.WriteLine(result.ToString());
            }
        }

        public static void getEnums2()
        {
            var results = Enum.GetValues(typeof(EnumTest.IntensityLevel))
                .Cast<EnumTest.IntensityLevel>()
                .Select(il => new { id = (int)il, name = il.ToString() })
                .ToList();

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}

//EnumTest.getEnums1();
//EnumTest.getEnums2();