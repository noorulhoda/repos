using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi_Identity
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        [ForeignKey("user")]
        public string userID { get; set; }
        public virtual IdentityUser user { get; set; }
    }
}