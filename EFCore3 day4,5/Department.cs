using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore3_day4_5
{
    class Department
    {
        //public Department(int id,string name) 
        //{
        //    Dept_Id = id;
        //    Dept_Name = name;
        //}
        [Key]
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
        public ICollection<Instructor> Instructors;

    }
}
