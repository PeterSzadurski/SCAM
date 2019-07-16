using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCAM
{
    public class Creditcard
    {
        static bool ValidCard(long creditCard)
        {
            if (creditCard.ToString().Length != 16 && creditCard.ToString().Length != 15)
            {
                //  Console.WriteLine("here");
                return false;
            }
            int sum = 0;
            bool changeNum = false;
            for (int i = creditCard.ToString().Length - 1; i >= 0; i--)
            {
                int num = Int32.Parse((creditCard.ToString()[i]).ToString());
                if (changeNum)
                {
                    num = num * 2;
                    if (num > 9)
                    {
                        num -= 9;
                    }
                }
                // Console.WriteLine(num+" ");
                sum += num;
                changeNum = !changeNum;
            }
            //  Console.WriteLine("sum: "+sum);
            return (sum % 10 == 0);
        }
    }
}