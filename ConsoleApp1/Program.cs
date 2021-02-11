using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12:45:54PM";
            char[] StrArr = s.ToCharArray();
            string newStr = "";
            int hourr=0;
            if (s[8] == 'P')
            {
                if (int.Parse(s.Substring(0, 2)) == 12)hourr = 12;
                else
                hourr =(int.Parse(s.Substring(0, 2)) + 12)%24;
                // Console.WriteLine (int.Parse(s.Substring(0, 2)));
                //Console.WriteLine(hourr);   
            }
            if (s[8] == 'A')
            {
                 hourr = (int.Parse(s.Substring(0, 2))) % 12;
                // Console.WriteLine (int.Parse(s.Substring(0, 2)));
                //Console.WriteLine(hourr);
            }
            if (hourr != 0)
            {
                if (hourr < 10)
                {
                    StrArr[0] = '0';
                    StrArr[1] = (hourr.ToString())[0];
                }
                else
                {
                    StrArr[0] = (hourr.ToString())[0];
                    StrArr[1] = (hourr.ToString())[1];
                }

            }
            else
            {
                StrArr[0] = '0';
                StrArr[1] = '0';

            }
           
                StrArr[3] = s[3];
                StrArr[4] = s[4];
                StrArr[5] = s[5];
                StrArr[6] = s[6];
                StrArr[8] = ' ';
                StrArr[9] = ' ';


            
            for(int c=0;c<StrArr.Length-2; c++)
                newStr += StrArr[c];
             Console.Write(newStr);
        }
    }
}
