using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore3_day4_5
{
    class Context:DbContext
    {
        public Context() 
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5VBV4FQ;Initial Catalog=EF3Academy;Integrated Security=True");
        }
        public virtual DbSet<Department> Departments { set; get; }
        public virtual DbSet<Instructor> Instructors { set; get; }

    }
}
