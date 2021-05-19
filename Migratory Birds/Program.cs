using System;
using System.Collections.Generic;
using System.Linq;

namespace Migratory_Birds
{
    class Program
    {
        static int migratoryBirds(List<int> arr)
        {
            List<int> fr=new List<int> (){0,0,0,0,0,0,0};
            for (int i = 0; i < arr.Count; i++)
            {
                fr[arr[i]]++;
            }
           return  fr.IndexOf(fr.Max());

        }
        static string dayOfProgrammer(int year)
        {

            string d="";
            if (year >= 1700 && year <= 1917)
            {
                if (year % 4 == 0)
                    d = "12.09.";
                else
                    d = "13.09.";
            }
            else
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    d = "12.09.";
                else
                    d = "13.09.";
            }
            return d + year;
        }
        public static int countingValleys(int steps, string path)
        { int res=0;
            char[] c= path.ToCharArray();
            int[] i=new int[steps];
            int sum = 0 ;
            for(int s=0 ; s < c.Length ;s++)
            {
                if (c[s] == 'U') sum++;
                else sum--;
                i[s] = sum;
            }
           for(int f = 1; f < i.Length; f++)
            {if (i[f] == 0 && i[f - 1] < 0) res++;

            }
            return res; 
        }
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int sum = 0;
            for(int i = 0; i < bill.Count; i++)
            {
                if (i != k) sum += bill[i];
            }
            int owe = b-(sum / 2) ;
            if (owe != 0)
                Console.WriteLine(owe);
            else
            Console.WriteLine("Bon Appetit");

        }
        static int findDigits(int n)
        {
            int res=0;
            char[] arr=n.ToString().ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case '1':
                        res++;break;
                    case '2':
                        if (n % 2 == 0) res++;break;
                    case '3':
                        if (n % 3 == 0) res++; break;
                    
                    case '4':
                        if (n % 4 == 0) res++; break;
                    case '5':
                        if (n % 5 == 0) res++; break;
                    case '6':
                        if (n % 6 == 0) res++; break;
                    case '7':
                        if (n % 7 == 0) res++; break;
                    case '8':
                        if (n % 8 == 0) res++; break;
                    case '9':
                        if (n % 9 == 0) res++; break;
                }
            }
            return res;
        }
        //6,2,2
        //1576 9 645
        static int chocolateFeast(int availableCash, int price, int wrapperDiscount)
        {
            int eaten = 0;
            int wraps = 0;

            wraps = eaten = availableCash / price;

            while (wraps >= wrapperDiscount)
            {
                int newlyEaten = wraps / wrapperDiscount;
                eaten += newlyEaten;
                wraps %= wrapperDiscount;
                wraps += newlyEaten;
            }


            return eaten;
        }
     
        public static int pairs(int k, int[] arr) {
            int counter = 0;
            HashSet<int> value = new HashSet<int>();
            foreach (int i in arr) {
                value.Add(i);
            }
            foreach (int i in value) {
                if (value.Contains(i + k)) {
                    ++counter;
                }
            }
            return counter; }

        public static int[] ice(int k, int[] arr)
        {
            int[] res = new int[2];
            int cont = -1;
           
            HashSet<int> value = new HashSet<int>();
            foreach (int i in arr)
            {
                value.Add(i);
            }
            for(int i= 0;i<arr.Length;i++)
            {
                if (value.Contains(Math.Abs(arr[i] - k)))
                {
                    res[++cont] = i + 1;
                }
            }
            return res;
        }
        static int[] icecreamParlor(int m, int[] arr)
        {
            int[] res = new int[2];
            int cont = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.Exists(arr, c => c == Math.Abs(arr[i] - m)))
                {
                    
                  
                   
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(countingValleys(12, "DDUUDDUDUUUD"));
            //Console.WriteLine(dayOfProgrammer(1700));
            //Console.WriteLine(migratoryBirds( new List<int> (){1,1,1}));
            //bonAppetit(new List<int>() { 3, 10, 2, 9 },1,7);
            // Console.WriteLine(chocolateFeast(1576, 9 ,645));
            int[] i = { 1, 4 ,5 ,3 ,2 };
            int[] r=ice(4,i);
            foreach (int b in r) Console.WriteLine(b);
        }
    }
}
