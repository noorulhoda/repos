using System;

namespace jumps
{
    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string result = "NO";
            long i; long j; long k;
            for (i = x1, j = x2, k = 0; k <= 1000000&&result=="NO"; k++, i += v1, j += v2)
                if (i == j)
                result = "YES";
            return result;
        }
        
        static void Main(string[] args)
        {
      
            
            Console.WriteLine(kangaroo(0,2,5,3)); 
        }
    }
}
