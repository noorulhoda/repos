using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcday777.Controllers
{   [HandleError]
    public class HomeController : Controller
    {
        [OutputCache(Duration=5)]
        public ActionResult Index()
        {

            // return Content(DateTime.Now.ToString(""));
            return View();
        }

        public ActionResult About()
        {
            //it make a dev exception not user exception ---custom errors is on
            throw new Exception("there is a problem heeere -___-");
            ViewBag.Message = "Your application description page.";
          
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}