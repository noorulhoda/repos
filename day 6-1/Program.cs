using System;
using System.Collections.Generic;

namespace day_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee emp1 = new Employee("noor",10000);
            Employee emp2= new Employee("esraa",5000);
            Company c = new Company("valeo",20000);

            c.addEmployee(emp1);
            c.addEmployee(emp2);

            emp1.increaseSalary(500);
            emp2.increaseSalary(3000);
            Console.WriteLine(c);

            List<Employee> filtered=c.filteration(e => e.salary > 8000);
            foreach(Employee e in filtered)
                   Console.WriteLine(e);
        }
    }
}
