using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_d2_Extension_metods
{
    public static class Extention
    {
        public static IEnumerable<int> yldReverseMe(this int num)
        {
            char[] ch = num.ToString().ToCharArray();
   
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                
                yield return int.Parse(""+ch[i]);
            }
            
        }
        public static int reverseMe(this int num)
        {
           char[] ch =num.ToString().ToCharArray();
            string s="";
            for(int i = ch.Length-1;i>=0 ; i--)
            {
                s += ch[i];
            }
            return int.Parse(s);
        }
        public static int NumOfDigits(this int num)
        {
            return num.ToString().Length;
        }
        public static string TrimAllSpcs(this string ss)
        {
            char[] s = ss.ToCharArray();
            string trimmed="";
            for (int i = 0; i < s.Length; i++)
                if (s[i] != ' ') trimmed += s[i];
            return trimmed;
        }
    }
}
