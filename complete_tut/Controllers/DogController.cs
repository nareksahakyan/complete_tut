using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using complete_tut.Models;

namespace complete_tut.Controllers
{
    public class DogController : Controller
    {
        // GET: Dog
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            dog dog = new dog
            {
                Id = 7,
                Name = "Lord woofington",
                BirthDate = new DateTime(year: 2005, month: 06, day: 27)
            };
            return View(dog);
        }

        public string Bark()
        {
            return "woof";
        }
    }
}