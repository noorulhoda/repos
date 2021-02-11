using System;
using System.Collections.Generic;

namespace LINQ_d2_Extension_metods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 123456;
            Console.WriteLine(n);
            int nn=n.reverseMe();
            Console.WriteLine(nn);
            int d= n.NumOfDigits();
            Console.WriteLine(d);
            IEnumerable<int> l = n.yldReverseMe();
            Console.WriteLine("yld revrsd :" );
            foreach (int i in l) Console.Write(i);
           
            Console.WriteLine($"{Environment.NewLine}================");
            string s = "  nkml   ll;'  vhvbk  ghbjjknnk   ";
            Console.WriteLine(s);
            string neew=s.TrimAllSpcs();
            Console.WriteLine(neew);
        }
    }
}
