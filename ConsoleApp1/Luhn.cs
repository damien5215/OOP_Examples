using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Luhn
    {
        public static bool CheckNo(string cardNumber)
        {
            int result2 = 0;
            int dummyVar = 0;

            char[] charArr = cardNumber.ToCharArray();
            Array.Reverse(charArr);
            int[] cardNo = new int[charArr.Length];

            for (int i = 0; i < cardNo.Length; i++) 
            {
                cardNo[i] = Convert.ToInt32(charArr[i].ToString());
            }

            for (int i = 0; i < charArr.Length; i++) 
            {
                if (i % 2 != 0) 
                {
                    if (cardNo[i] > 4)
                    {
                        int dummyVar4 = 0;
                        string dummyVar2 = "";
                        dummyVar = cardNo[i] * 2;

                        dummyVar2 = dummyVar.ToString();
                        char[] dummyVar3 = dummyVar2.ToCharArray();
                        dummyVar4 = Convert.ToInt32(dummyVar3[0].ToString()) + Convert.ToInt32(dummyVar3[1].ToString());
                        result2 += dummyVar4;
                    }
                    else 
                    {
                        result2 += cardNo[i] * 2;
                    }
                }
                else 
                {
                    result2 += cardNo[i];
                }
            }

            Console.WriteLine(result2 + "\n");

            if (result2 % 10 == 0) 
            {
                Console.WriteLine(true + "\n");
                return true;
            }
            else 
            {
                Console.WriteLine(false + "\n");
                return false;
            }
        }

    }
}

// false
//Luhn.CheckNo("1234123412341234");

// true
//Luhn.CheckNo("4121144444444444");