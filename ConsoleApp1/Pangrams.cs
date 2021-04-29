using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pangrams
    {
        public static void Pangram(string input)
        {
            string result = input.Replace(" ", "").ToLower();
            bool[] flagArray = new bool[26];

            for(int i = 0; i < result.Length; i++) 
            {
                flagArray[result[i] - 97] = true; 
            }

            if (flagArray.ToList().Contains(false))
            {
                Console.WriteLine("The string - " + input + "\n" + "\n" + 
                                  "is NOT a Pangram!" + "\n" + "\n");
            }
            else 
            {
                Console.WriteLine("The string - " + input + "\n" + "\n" + 
                                  "is a Pangram!" + "\n" + "\n");
            }
        }
    }
}

//string s1 = "We promptly judged antique ivory buckles for the next prize";
//string s2 = "The quick brown fox jumps over the lazy dog";
//string s3 = "abcd efg hijk lmnop qrs tuv wx";
//string s4 = "abcd efg hijk lmnop qrs tuv wx yz";
//Pangrams.Pangram(s1);
//Pangrams.Pangram(s2);
//Pangrams.Pangram(s3);
//Pangrams.Pangram(s4);