using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCAM
{
     public class Creditcard
    {
        public int creditCardId { get; }
        public string name { get; }
        public long number { get; }
        public DateTime expiration { get; }
        public string ccv { get; }
        public string username { get; }
        public Creditcard() {

        }
        public Creditcard(int ccID, string Name, long num, 
            DateTime Expiration, string Ccv, string Username) {
            creditCardId = ccID;
            name = Name;
            number = num;
            expiration = Expiration;
            ccv = Ccv;
            username = Username;
        }
       public static bool ValidCard(long creditCard)
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