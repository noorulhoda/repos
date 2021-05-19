using day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [Route("std/{id}/{name}")]
        public ActionResult stdDetails(int id,string name)
        {
            Student s = new Student(id, name , "ali", 41,"");
            return View(s);
        }
    }
}