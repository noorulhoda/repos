using System;

namespace day3
{
    public class point
    {
        int x;
        int y;
        int z;
        public point() : this(1, 2, 3)
        {
        }
        public point(int xx, int yy, int zz)
        {
            x = xx;
            y = yy;
            z = zz;
        }
        public void display()
        {
            Console.WriteLine($"({x},{y},{z})");
        }
        public void change(int nx, int ny, int nz)
        {
            x = nx;
            y = ny;
            z = nz;
        }
        public override string ToString()
        {
            return $"({x},{y},{z})";
        }
        public override bool Equals(object obj)
        {
            point p = obj as point;
            if (p != null)
            {
                if (x == p.x && y == p.y && z == p.z)
                    return true;
            }
            return false;
        }
    }
  
    class Program
    {
        public static void DisplayArray(point[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i].ToString());
        }
        static void Main(string[] args)
        {
            point p1 = new point(2, 3, 5);
            point p2 = new point(2, 3, 5);
            if (p1 == p2) Console.WriteLine("the same");
            else Console.WriteLine("diffrent");
            if (p1.Equals(p2)) Console.WriteLine("Equal");
            else Console.WriteLine("notEqual");
            
            point[] arr = new point[2];
            arr[0] = p1;
            arr[1] = p2;
            DisplayArray(arr);
        }
    }
}
