using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public static class sampleData
    {
        public static List<Employe> Employes= new List<Employe>() {};
        public static List<Department> Departments= new List<Department>() {};  
         static sampleData()
        {
            Employe e1 = new Employe() { id = 1, name = "n1", salary = 1000, DeptID = 1 };
            Employe e2 = new Employe() { id = 1, name = "n2", salary = 2000, DeptID = 1 };
            Employe e3 = new Employe() { id = 1, name = "n3", salary = 3000, DeptID = 2 };
            Employe e4 = new Employe() { id = 1, name = "n4", salary = 4000, DeptID = 2 };

            Department d1 = new Department() { id = 1, name = "d1" };
            Department d2 = new Department() { id = 2, name = "d2" };
            Employes.Add(e1); Employes.Add(e2); Employes.Add(e3); Employes.Add(e4);
            Departments.Add(d1); Departments.Add(d2);
        }


    }
}
