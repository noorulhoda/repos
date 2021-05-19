using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCORE.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        [ForeignKey("Class")]
        [DisplayName("Class")]
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
