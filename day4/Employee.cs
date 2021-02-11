using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    class Employee : person,IPayable
    {
        string NID;
        public int salary { set; get; }
        public Employee(string n, int s)
        {
            NID = n;
            salary = s;
        }
        public override string ToString()
        {
            return $"this Emp nid :{NID}\tsal:{salary}";
        }
        public void showPayment()
        {
            Console.WriteLine(salary);

        }
    }
}
