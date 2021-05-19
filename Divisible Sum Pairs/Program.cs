using System;
using System.Collections.Generic;

namespace Divisible_Sum_Pairs
{
    class Program
    {
        static int divisibleSumPairs( int n, int k, int[]s)
        {
            int res = 0, i, j; int sum = 0;
            for (i = 0; i < s.Length ; i++)
            {

                for (j = i+1; j < s.Length ; j++)
                {
                    sum = s[i];
                    sum += s[j];
                    if (sum % k == 0) res++;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] i = { 1, 3, 2, 6, 1, 2 };
            Console.WriteLine(divisibleSumPairs(6,3,i));
        }
    }
}
