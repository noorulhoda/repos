using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore3_day4_5
{
    class Instructor
    {
        //public Instructor(int id, string name,int dID,int sal)
        //{
        //    Ins_Id = id;
        //    Ins_Name = name;
        //    Dept_Id = dID;
        //    Salary = sal;
        //}
        [Key]
        public int Ins_Id { get; set; }
        public string Ins_Name { get; set; }
        public int Salary { get; set; }
        //[ForeignKey ("D")]
        public int Dept_Id { get; set; }
        public Department dept { get; set; }
    }
}
