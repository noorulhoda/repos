using System;

namespace break_the_record
{
    class Program
    {
        static int[] breakingRecords(int[] scores)
        {
            int max = scores[0]; int min = scores[0]; int win = 0; int lose = 0;
            int i = 0;
            for (i = 1; i < scores.Length; i++)
            {
                if (scores[i] > max) { max = scores[i]; win++; }
                if (scores[i] < min) { min = scores[i]; lose++; }
            
            }
            int[] arr = new int[2];
            arr[0] = win;
            arr[1] = lose;
            return arr;

        }
        static void Main(string[] args)
        {
            int[] i = { 10 ,5 ,20 ,20, 4, 5 ,2, 25 ,1 };
            int[]r= breakingRecords(i);
            foreach (int item in r )
                Console.WriteLine(item);
        }
    }
}
