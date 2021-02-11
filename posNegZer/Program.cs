using System;

namespace posNegZer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, -5, 7 ,0};
            int p = 0;
            int n = 0;
            int z = 0;
            foreach (int i in arr)
            {

                if (i > 0) p++;
                if (i < 0) n++;
                if (i == 0) z++;
                
            }
            Console.WriteLine((float)p/arr.Length);
            Console.WriteLine((float)n /arr.Length);
            Console.WriteLine((float)z /arr.Length);
        }
    }
}
