using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8_2
{
    class student
    {
        public string name;
        public string phone;
        public DateTime date;
        public student(string n, string p, DateTime d)
        {
            name = n;phone = p;date = d;
        }
    }
    class studentsData
    {
        public static List<student> students = new List<student>()
        {
            new student("noor","85475",new DateTime(1999,2,2)),
            new student("ali","78521405",new DateTime(1997,8,9)),
            new student("ibtesam","879999",new DateTime(1998,1,1))

        };

    }

}
