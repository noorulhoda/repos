using System;

namespace day4
{
    class Program
    {
        public static void DisplayArray(object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i].ToString());
            Console.WriteLine("--------------------");
        }
        
        static void Main(string[] args)
        {
            point p1 = new point(4, 3, 5);
            point p2 = new point(2, 3, 5);
            point p3 = p1.Clone() as point;
            point[] arr = new point[3];
            arr[0] = p1;
            arr[1] = p2;
            arr[2] = p3;
            DisplayArray(arr);
            Array.Sort(arr);
            DisplayArray(arr);
            /////////////////////////////////
            Trainee[] Trainees = new Trainee[3];
            Trainees[0]=new Trainee("44444","55",10000);
            Trainees[1] = new Trainee("555555", "56", 70000);
            Trainees[2]= new Trainee("44444", "57", 9000);
            DisplayArray(Trainees);
            Array.Sort(Trainees, new ComparerClass());
            DisplayArray(Trainees);
            Trainee tt = Trainees[0]++;
            
        }
    }
}
