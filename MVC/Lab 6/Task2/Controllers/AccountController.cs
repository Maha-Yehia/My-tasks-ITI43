using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Task2.Models;

namespace Task2.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Client c)
        {
            if(ModelState.IsValid)
            {
                Identity_DB context = new Identity_DB();
                context.Clients.Add(c);
                context.SaveChanges();
                var userIdentity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim("Name" , c.ClientName), 
                    new Claim("Password" , c.Password),
                    //new Claim("Address" , c.Address),
                    //new Claim("Mobile" , c.Mobile),
                    new Claim(ClaimTypes.Email , c.Email),
                } , "AppCookie");
                Request.GetOwinContext().Authentication.SignIn(userIdentity);
                return RedirectToAction("Index", "Home"); 
            }
            return View();
        }

        public ActionResult Login()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult Login(Client cl)
        {
            Identity_DB context = new Identity_DB();
            var loggedUser = context.Clients.FirstOrDefault
                (c=>c.Email== cl.Email && c.Password==cl.Password);
         if(loggedUser != null) {
                var signInIdentity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim(ClaimTypes.Email , cl.Email),
                    new Claim("Password" , cl.Password)
                } , "AppCookie");
                Request.GetOwinContext().Authentication.SignIn(signInIdentity);
                return RedirectToAction ("Index", "Home"); 
            }
            else
            {
                ModelState.AddModelError("Name", "User is not existed"); 
                return View();

            }
        }

        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("AppCookie"); 
            return RedirectToAction("Login");
        }
      
      
    }
}