using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi_Identity;

namespace IdentityOAuth.Models
{
    public class ApplicationDbContext : IdentityDbContext //user/role/claims
    {
        public ApplicationDbContext() : base("CS")
        {

        }
        public virtual DbSet<Student> students { get; set; }
    }
}