using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    class ComparerClass:IComparer<Trainee>
    {
        public int Compare(Trainee x, Trainee y)
        {
            return (y.salary.CompareTo(x.salary));
        }
    }
}
