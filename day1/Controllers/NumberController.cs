using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day1.Controllers
{
    public class NumberController : Controller
    {
        // GET: Number
        public ActionResult even()
        {
            List<int> evens = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) evens.Add(i);
            }

            return View(evens);
        }
    }
}