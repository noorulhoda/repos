using day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day1.Controllers
{
    public class IntakeController : Controller
    {
        // GET: Intake
        public ActionResult showIntakeStudents()
        {
            Student s1 = new Student(1, "noor", "ali", 41, "b.jpg");
            Student s2 = new Student(2, "esraa", "ali", 41, "g.jpg");
            Student s3 = new Student(3, "masheah", "ali", 41, "u.jpg");
            intake i = new intake(new List<Student>() { s1, s2, s3 });
            return View(i);
        }
    }
}