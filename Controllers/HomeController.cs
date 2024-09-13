using Microsoft.AspNetCore.Mvc;
using TaskMonitoring.Models;

namespace TaskMonitoring.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // This will return the Index view which includes the login form
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model); // Return to Index view with validation errors
            }

            // Example login logic
            if (model.Username == "admin" && model.Password == "password")
            {
                // Handle successful login
                return RedirectToAction("Homepage"); // Redirect to Homepage action
            }

            // If login fails
            ModelState.AddModelError(string.Empty, "Invalid username or password");
            return View("Index", model); // Return to Index view with validation errors
        }

        public IActionResult Homepage()
        {
            return View(); // This will return the Homepage view
        }

        public IActionResult Profilepage()
        {
            return View();
        }
    }
}
