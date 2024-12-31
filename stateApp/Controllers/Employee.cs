using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace stateApp.Controllers
{
    public class Employee : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ValidateEmployee()
        {
            string UserId = Request.Form["UserId"].ToString();
            string Pwd = Request.Form["Pwd"].ToString();
            if (UserId.ToLower().Equals("jhon") && Pwd.Equals("1235"))
            {
  
               Request.HttpContext.Session.SetString("Username",UserId);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index","Home");
            }
        }
        public IActionResult Logout()
        {
            Request.HttpContext.Session.Remove("username");
            return RedirectToAction("Index","Home");
        }
        public IActionResult Register()
        { 
            return View();
        }
    }
}
