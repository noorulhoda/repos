using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using mvcday777.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcday777.Controllers
{
        [AllowAnonymous]
        public class AccountController : Controller
        {
            // GET: Account
            public ActionResult Login()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Login(LoginVM userLogin)
            {
            if (!ModelState.IsValid)
                return View(userLogin);
            try
            {
                //Creat UserManager
                ApplicationIdentityDbContext context = new ApplicationIdentityDbContext();
                UserStore<ApplicationIdentityUser> store = new UserStore<ApplicationIdentityUser>(context);
                UserManager<ApplicationIdentityUser> manager =
                    new UserManager<ApplicationIdentityUser>(store);
          
                //UserLoginInfo u = new UserLoginInfo(userLogin.Password);
                //UserManager save user database
                
                //manager.AddToRole(user.Id, "Student");
                //MAnager SignIn
                //ClaimsIdentity
                IAuthenticationManager authenticationManager =
                        HttpContext.GetOwinContext().Authentication;
                    SignInManager<ApplicationIdentityUser, string> signinmanager =
                        new SignInManager<ApplicationIdentityUser, string>
                        (manager, authenticationManager);
              signinmanager.PasswordSignIn(userLogin.Username, userLogin.Password,
               true, true);
               
                //Cookie Authoriz
                return RedirectToAction("Index", "Home");
              

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(userLogin);
            }
           
            }

            public ActionResult Registration()
            {
                //Applicatiouser "Adress
                return View();
            }
            [HttpPost]
            public ActionResult Registration(RegistrationVM userRegister)
            {
                if (!ModelState.IsValid)
                    return View(userRegister);
                try
                {
                    //Creat UserManager
                    ApplicationIdentityDbContext context = new ApplicationIdentityDbContext();
                    UserStore<ApplicationIdentityUser> store = new UserStore<ApplicationIdentityUser>(context);
                    UserManager<ApplicationIdentityUser> manager =
                        new UserManager<ApplicationIdentityUser>(store);
                    //Map Vm To Model
                    ApplicationIdentityUser user = new ApplicationIdentityUser();
                    //user.UserName = userRegister.Email;
                    user.UserName = userRegister.Username;
                    user.PasswordHash = userRegister.Password;
                    user.Email = userRegister.Email;
                    user.Address = userRegister.Adress;

                    //UserManager save user database
                    IdentityResult resulte = manager.Create(user, userRegister.Password);
                    if (resulte.Succeeded)
                    {
                        //manager.AddToRole(user.Id, "Student");
                        //MAnager SignIn
                        //ClaimsIdentity
                        IAuthenticationManager authenticationManager =
                            HttpContext.GetOwinContext().Authentication;
                        SignInManager<ApplicationIdentityUser, string> signinmanager =
                            new SignInManager<ApplicationIdentityUser, string>
                            (manager, authenticationManager);
                        signinmanager.SignIn(user, true, true);
                        //Cookie Authorize
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", (resulte.Errors.ToList())[0]);
                        return View(userRegister);

                    }

                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(userRegister);
                }
            }

            [Authorize]
            public ActionResult Signout()
            {
                IAuthenticationManager manger = HttpContext.GetOwinContext().Authentication;

                manger.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                return RedirectToAction("Index", "Home");
            }
        }
    }
