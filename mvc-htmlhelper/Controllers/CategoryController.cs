using mvcDay2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDay2.Controllers
{
    public class CategoryController : Controller
    {
        MyCompanyEntities context = new MyCompanyEntities();
        // GET: Category
        public ActionResult showAllProducts(int id)
        {
            CategoriesType ctgr = context.CategoriesType.FirstOrDefault(context => context.Id == id);
            
            return View(ctgr);
        }
        public ActionResult showAllProductsPartialView(int id)
        {
            CategoriesType ctgr = context.CategoriesType.FirstOrDefault(context => context.Id == id);

            return PartialView("_PVShowProducts",ctgr);
        }
        public ActionResult search(string categoryName)
        {
            List<CategoriesType> ctgrs = context.CategoriesType.Where(c => c.CategoryName.Contains( categoryName)).ToList();
            ViewBag.ctgList = ctgrs;
            ViewBag.categoryName = categoryName;
            return View("showAllProductInStock");
        }
        public ActionResult showAllProductInStock()
        {
            ViewBag.ctgList = context.CategoriesType.ToList();
            return View();
        }
        public ActionResult showAllCategories()
        {
            List<CategoriesType> ctgrs = context.CategoriesType.ToList();
            ViewBag.ctgList = ctgrs;
            return View();
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(string CategoryName)
        {
            CategoriesType c = new CategoriesType();
            c.CategoryName = CategoryName;
            context.CategoriesType.Add(c);
            context.SaveChanges();
            return RedirectToAction("showAllCategories");
        }

    }
}