using Microsoft.AspNetCore.Mvc;

namespace BankDemo.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection c)
        {
            string k = c["username"].ToString();
            string p = c["password"].ToString();
            if (k == "nandhu" && p == "N@ndhu")
            {
                return RedirectToRoute(new { action = "Index", controller = "Home", area = "" });
            }
            else
            {
                ViewBag.Message1 = "Invalid username/password";
                return View();
            }
        }

    }
}
