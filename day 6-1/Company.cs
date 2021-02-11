using System;
using System.Collections.Generic;
using System.Text;

namespace day_6_1
{
    class Company
    {
        public string name;
        public float budget;
        List<Employee> Employees=new List<Employee>();
        public Company(string n,float b)
        {
            name = n;
            budget = b;
        }
        public void thereisIncreasement(float f)
        {
            budget -= f;
        }
        public override string ToString()
        {
            return $"{name} budget is {budget}";
        }
        public void addEmployee(Employee e)
        {
            Employees.Add(e);
            e.salaryIncreasedNotifyingList += thereisIncreasement;
        }
        public List<Employee> filteration(Predicate<Employee> filter )
        {
            List<Employee> highSalariedEmployees = new List<Employee>();
            foreach(Employee e in Employees)
            {
                if (filter(e)) highSalariedEmployees.Add(e);
            }
            return highSalariedEmployees;
        }
       
    }
}
