using System;
using System.Collections.Generic;
using System.Text;

namespace day_6_1
{
    class Employee
    {
        public string name;
        public float salary;
        public event Action<float> salaryIncreasedNotifyingList;
        public Employee(string n,float s)
        {
            name = n;salary = s;
        }
        public void increaseSalary(float s)
        {
            salary += s;
            if (salaryIncreasedNotifyingList != null)
                salaryIncreasedNotifyingList(s);
        }
      

       
        public override string ToString()
        {
            return $"employee  {name} salary is {salary}";
        }
    }
}
