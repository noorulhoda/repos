using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcday777.Models
{
   
        public class ApplicationIdentityUser : IdentityUser
        {
            //Extra
            public string Address { get; set; }

        }

    
        //DbContext
        public class ApplicationIdentityDbContext :
            IdentityDbContext<ApplicationIdentityUser>
        {
            public ApplicationIdentityDbContext() : base("CS")
            {

            }
            public ApplicationIdentityDbContext(string name) : base(name)
            {

            }
        public class Order
        {
            public int ID { get; set; }
            public string Date { get; set; }
            public int Discount { get; set; }
            public string User_Id { get; set; }

            [ForeignKey("User_Id")]
            public virtual ApplicationIdentityUser Users { get; set; }
        }
        public DbSet<Order> Orders { get; set; }

       // public System.Data.Entity.DbSet<ApplicationIdentityUser> ApplicationIdentityUsers { get; set; }
        //public DbSet<PRoduct> Product { get; set; }


    }
}