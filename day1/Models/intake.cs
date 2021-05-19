using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace day1.Models
{
    public class intake
    {
       public List<Student> students;
       public intake(List<Student> l)
        {
            students = l;
        }
    }
}