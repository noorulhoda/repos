using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using mvcday777.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcday777.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string RoleName)
        {
            if (RoleName != null)
            {
                ApplicationIdentityDbContext context =
                    new ApplicationIdentityDbContext();
                //Store
                RoleStore<IdentityRole> store =
                    new RoleStore<IdentityRole>(context);
                //Role Add -update-find
                RoleManager<IdentityRole> manager =
                    new RoleManager<IdentityRole>(store);
                IdentityRole role = new IdentityRole(RoleName);
                IdentityResult resut = manager.Create(role);
                if (resut.Succeeded == true)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Errors = resut.Errors;
                }
            }
            else
            {
                ViewBag.msgError = "Role NAme Empty";
            }

            ViewBag.RoleName = RoleName;
            return View();
        }
    }
}
