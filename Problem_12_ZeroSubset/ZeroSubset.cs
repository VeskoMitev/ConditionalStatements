

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using EnvDTE80;

namespace ConditionalStatements
{
    
    /*Problem 12.	* Zero Subset

     * We are given 5 integer numbers. Write a program that finds all subsets of 
     * these numbers whose sum is 0. Assume that repeating the same subset several times is not a problem. 
     */ 

    using System;
    class ZeroSubset
    {
         static  int countArrayNumber = 5;
         static  int count = 3;
        private static bool[] usedIndex = new bool[countArrayNumber];
        private static int[] arr = new int[count];
        private static List<int[]> result = new List<int[]>(); 
        static void Main(string[] args)
        {
            int[] inputArr = new int[countArrayNumber];// {1, 3, -4, -2, -1};

            inputArr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            count = 2;
            arr = new int[count];
            Variation(1,0);

            count = 3;
            arr = new int[count];
            Variation(1,0);

            count = 4;
            arr = new int[count];
            Variation(1,0);

            count = 5;
            arr = new int[count];
            Variation(1, 0);

            foreach (int[] mapIndex in result )
            {
                double resTmp = 0;
                for (int i = 0; i < mapIndex.Length ; i++)
                {
                    resTmp += inputArr[mapIndex[i]];
                }
                if (resTmp == 0)
                {
                    for (int i = 0; i < mapIndex.Length; i++)
                    {
                        if (i < mapIndex.Length - 1)
                        {
                            Console.Write("{0}({1}) + ", inputArr[mapIndex[i] ],mapIndex[i]);
                            
                        }
                        else
                        {
                           Console.Write("{0}({1}) = 0 ", inputArr[mapIndex[i] ],mapIndex[i]);
                            
                        }
                        
                    }
                    Console.WriteLine();
                }
            }
            
        }

        private static void Variation(int index,int after)
        {
           
            if (index>count)
            {
                return;
            }
            else
            {
               for (int i = after+1; i <= countArrayNumber; i++)
               {
                   arr[index-1 ] = i-1;
                   if (index == count)
                   {
                       int[] tmpArr = new int[count];
                       arr.CopyTo(tmpArr, 0);
                       result.Add(tmpArr);
                   }
                   Variation(index + 1, i);
               } 
            }
            
        }
    }
}
