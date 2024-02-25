using Microsoft.AspNetCore.Mvc;
using W01.Models;

namespace W01.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            People people1 = new People
            {
                Age = 21,
                FullName = "John Doe",
                Id = "122"
            };
            return View(people1);
        }
    }
}
