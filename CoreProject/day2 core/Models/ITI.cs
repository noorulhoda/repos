using day2_core;
using day2_core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProject.Model
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


