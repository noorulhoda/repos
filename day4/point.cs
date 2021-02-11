using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    public class point : IComparable<point>,ICloneable
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
        public  int CompareTo(point p)
        {
            return x.CompareTo(p.x);

        }
        public object Clone()
        {
            return new point(x,y,z);
        }
        /*public static implicit operator point(object o)
        {
            return new point(x, y, z);
        }*/
    }

}
