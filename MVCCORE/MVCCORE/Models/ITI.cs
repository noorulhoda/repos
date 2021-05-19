using MVCCORE;
using MVCCORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCORE.Model
{
   
        public class ITI : DbContext
        {
            public ITI() : base()
            {

            }
            public ITI(DbContextOptions options) : base(options)
            {

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ITICORE;Integrated Security=True");
            }
            public DbSet<Student> Student { get; set; }
            public DbSet<Class> Class { get; set; }
        }
    }


