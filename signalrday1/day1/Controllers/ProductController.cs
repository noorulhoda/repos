using day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace day1.Controllers
{
    public class ProductController : Controller
    {
        MyCompanyEntities context = new MyCompanyEntities();

        // GET: Product
        public ActionResult showDetails(int id)
        {
            Products prdct = context.Products.FirstOrDefault(p => p.Id == id);

            return View(prdct);
        }
    }
}