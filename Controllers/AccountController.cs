using Microsoft.AspNetCore.Mvc;
using TaskMonitoring.Models;

namespace TaskMonitoring.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // Return the view with validation errors
            }

            // Example login logic
            if (model.Username == "admin" && model.Password == "password")
            {
                return RedirectToAction("Index", "Home");
            }

            // If login fails
            ModelState.AddModelError(string.Empty, "Invalid username or password");
            return View(model);
        }

    }
}
