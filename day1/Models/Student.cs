using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace day1.Models
{
    public class Student
    {
        public int id;
        public string name;
        public string manager;
        public int intakeNo;
        public string img;
        public Student(int i,string n,string m,int intk,string g)
        {
            id = i;
            name = n;
            manager = m;
            intakeNo=intk;
            img = g;
        }
    }
}