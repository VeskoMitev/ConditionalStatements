namespace ConditionalStatements
{
    using System;
    using System.Numerics;
    class PetarsGame
    {
        static public string ReplaceFirstDigit(BigInteger number, string str)
        {
            string stringNumber = number.ToString();
            string firstDigit = stringNumber.Substring(0, 1);
            string result = stringNumber.Replace(firstDigit, str);
            return result;
        }
        static public string ReplaceLastDigit(BigInteger number, string str)
        { 
            string stringNumber = number.ToString();
            string lastDigit = stringNumber.Substring(stringNumber.Length-1, 1);
            string result = stringNumber.Replace(lastDigit, str);
            return result;
        }

        static public string MakeResult(BigInteger sum,string str)
        {
            string result;
            if (sum%2 == 0)
            {
                result = ReplaceFirstDigit(sum, str);
            }
            else
            {
               result = ReplaceLastDigit(sum, str); 
            }
            return result;
        }
        static public BigInteger CalcSum(ulong startNumber, ulong endNumber)
        {
            BigInteger result = 0;
            for (ulong i = startNumber ; i < endNumber ; i++)
            {
                if (i%5 == 0)
                {
                    result += i;
                }
                else
                {
                    result += i%5;
                }
            }
            return result;
        }
        static void Main()
        {
           
            ulong startNumber = ulong.Parse(Console.ReadLine());
            ulong endNumber = ulong.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            BigInteger calcSum = CalcSum(startNumber, endNumber);
            string result = MakeResult(calcSum, inputString);

            Console.WriteLine(result);
        }
    }
}
