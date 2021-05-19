using System;
using System.Collections.Generic;

namespace squares
{
    class Program
    {
        static int birthday(List<int> s, int d, int m)
        {
            int res=0, i, j;
            for (i = 0; i < s.Count-m+1; i++)
            {
                int sum = s[i];
                for (j = (i + 1); j < (i + m ); j++)
                    sum += s[j];
                 if (sum == d) res++;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(birthday(new List<int>(){4},4,1));
        }
    }
}
