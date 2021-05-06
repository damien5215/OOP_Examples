using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Editor
    {
        public string WordCount(string input) 
        {
            return input;
        }


        public string WordSenCount(string input) 
        {
            int totalWords = 0;
            string splitOn = ".";

            string result = input.Replace('?', '.').Replace('!', '.').Replace(". ", ".");

            string[] sentenceArray = result.Split(splitOn.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            int[] wordArr = new int[(sentenceArray.Length)];

            result = result + "\n" + "\n";

            for (int i = 0; i < sentenceArray.Length; i++)
            {
                wordArr[i] = sentenceArray[i].Split(' ').Length;
                totalWords += wordArr[i];
                result += "Sentence " + (i + 1) + " contains " + wordArr[i] + " words." + "\n";
            }
            result = result + "\n" + "Total words = " + totalWords;

            return result;
        }
    }
}
