using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace day2_core
{
    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
    public class ITIContext : DbContext
    {
        public ITIContext()
        {

        }

        public ITIContext(DbContextOptions<ITIContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Intakr401249;Integrated Security=True");
        }
        public DbSet<Student> Students { get; set; }
    }
}
