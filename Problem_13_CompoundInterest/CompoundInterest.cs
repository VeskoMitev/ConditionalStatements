using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13_CompoundInterest
{
   public class CompoundInterest
    {
        static public decimal PowDecimal(decimal x, uint y)
        {
            decimal result = x;
            for (int i = 1; i < y; i++)
            {
                result *= x;
            }
            return result;
            
        }
        static public decimal CalcBankLoan(decimal priceOfProduct, uint years, decimal rate)
        {
            decimal result = 0m;
            result = priceOfProduct * PowDecimal((1+rate), years);
            return result;
        }

       static public decimal CalcFriendLoan(decimal priceofProduct, decimal rate)
       {
           return priceofProduct*(1+rate);
       }

       static public string MakeResult(decimal bankLoan, decimal friendLoan)
       {
           string result = "";
           if (bankLoan<friendLoan)
           {
               result = string.Format("{0:0.00} Bank", bankLoan);
           }
           else
           {
               result = string.Format("{0:0.00} Friend", friendLoan);   
           }
           return result;
       }
        static void Main(string[] args)
        {
            
            decimal priceOfTV = decimal.Parse(Console.ReadLine());
            uint yearsOfLoan = uint.Parse(Console.ReadLine());
            decimal rateOfBank = decimal.Parse(Console.ReadLine());
            decimal rateOfFriend = decimal.Parse(Console.ReadLine());

            decimal bankLoan = CalcBankLoan(priceOfTV, yearsOfLoan, rateOfBank);
            decimal friendLoan = CalcFriendLoan(priceOfTV, rateOfFriend);

            Console.WriteLine(MakeResult(bankLoan,friendLoan ));

        }
    }
}
