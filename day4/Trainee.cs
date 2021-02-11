using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    class Trainee : person,IPayable
    {   public int salary { set; get; }
        string NID;
        string intake;
        public Trainee(string n, string i,int s)
        {
            NID = n;
            intake = i;
            salary = s;
        }
        public static Trainee operator ++(Trainee c)
        {
            return new Trainee(c.NID,c.intake,c.salary + 1000);
        }
        public override string ToString()
        {
            return $"this trainee nid :{NID}\tintake:{intake}\tsalary:{salary}";
        }
         public void showPayment()
        {
            Console.WriteLine(salary);
        }

    }
}
