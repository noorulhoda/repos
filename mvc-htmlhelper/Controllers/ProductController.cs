using AutoMapper;
using mvcDay2.Models;
using mvcDay2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcDay2.Controllers
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
        public ActionResult showColoredDetails(int id)
        {
            //Initialize the mapper
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Products, productQtyColor>());
            //Creating the source object
            Products prdct = context.Products.FirstOrDefault(p => p.Id == id);
            //Using automapper
            var mapper = new Mapper(config);
            productQtyColor prdctColoredVM = mapper.Map<productQtyColor>(prdct);
            if (prdctColoredVM.Quantity > 5) prdctColoredVM.Color = "Green";
            else prdctColoredVM.Color = "Red";
            return View(prdctColoredVM);
        }
      
        [HttpGet]
        public ActionResult AddProduct()
        {
            TempData["categories"] = context.CategoriesType.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Products pr, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.ContentLength > 0)
                {
                    var f = System.IO.Path.GetFileName(file.FileName);//file is null
                    file.SaveAs(Server.MapPath("~/Content/" + f));
                    pr.image = f;
                }
                context.Products.Add(pr);
                context.SaveChanges();
                return RedirectToAction("showAllProducts", "Category", new { id = pr.CategoryId });
               

            }
            ViewBag.categories = context.CategoriesType.ToList();
            return View(pr);


        }
        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            Products p = context.Products.FirstOrDefault(pr => pr.Id == id);
            CategoriesType c = context.CategoriesType.FirstOrDefault(ct => ct.Id == p.CategoryId);
            ViewBag.categories = context.CategoriesType.ToList();
            return View(p);
        }
        [HttpPost]
        public ActionResult EditProduct(Products p, HttpPostedFileBase file)
        {
            Products prdct = context.Products.FirstOrDefault(pr => pr.Id == p.Id);
            //how to get value of select of html ?/prdct.CategoryId = p.CategoryId;
            prdct.Color = p.Color;
            prdct.Description = p.Description;
            prdct.Name = p.Name;
            prdct.CategoryId = p.CategoryId;
            if (file != null && file.ContentLength > 0)
            {
                var f = System.IO.Path.GetFileName(file.FileName);//file is null
                file.SaveAs(Server.MapPath("~/Content/" + f));
                prdct.image = f;
            }
            context.SaveChanges();
            return RedirectToAction("showAllProducts", "Category", new { id = p.CategoryId });
        }
        public ActionResult DeleteProduct(int id)
        {
            Products deleted = context.Products.FirstOrDefault(p => p.Id== id);
            Nullable<int> deletedCategID = deleted.CategoryId;
            context.Products.Remove(deleted);
            context.SaveChanges();
            return RedirectToAction("showAllProducts", "Category", new { id = deletedCategID });
        }
        public ActionResult checkPrice(int Price)
        {
            if (Price > 0) return Json(true,JsonRequestBehavior.AllowGet);
            return Json(false,JsonRequestBehavior.AllowGet);
        }

    }
}