using HTMLHelpers.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace HTMLHelpers.Controllers
{
    public class The_UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Countries = new List<string> { "USA", "Canada", "Germany", "UK", "India", "Australlia" };
            ViewBag.Skills = new List<string> { "CSharp", "JS", "Python", "Java", "PHP" };

            return View(new User());
        }

        [HttpPost]
        public ActionResult submit(User user)
        {
            if (ModelState.IsValid) {
                return View("Success", User);
            }
            ViewBag.Countries = new List<string> { "USA", "Canada", "Germany", "UK", "India", "Australlia" };
            ViewBag.Skills = new List<string> { "CSharp", "JS", "Python", "Java", "PHP" };

            return View("Index", user);
        }
    }
}
