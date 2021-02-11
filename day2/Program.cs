using System;

namespace day2
{
    enum Role
    {
        Admin = 1 ,
        Accountant =2,
        Stock =4,
        Reception =8
    }
    struct Employee
    {
        public string Name;
        public int salary;
        public Role role;
        public Employee(string n,int s,Role r)
        {
            Name = n;
            salary = s;
            this.role = r;
        }
        public void display()
        {
            Console.WriteLine($"Name{Name}\tsalry{salary}\tRole{role}");
        }
        public void assignRole(Role r)
        {
            this.role = role | r;
        }
        public bool hasRole(Role r)
        {
            return   ((role & r) == r);
        }
    }
    class Program
    {   

        static void Main(string[] args)
        {
            Employee e = new Employee("noor", 10000, Role.Accountant);
            e.assignRole(Role.Admin);
            if (e.hasRole(Role.Admin)) Console.WriteLine("she is admin");
            e.display();

        }
    }
}
