using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunFriday.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            if (a == "a")
            {
                TempData["AlertMessage"] = "Sing " +
                    "a song ";
            }
            if (b == "b")
            {
                TempData["AlertMessage"] = "How does function breakup ?";
            }
            if (c == "d")
            {
                TempData["AlertMessage"] = "What celebrity would you rate as a perfect 10 ?";
            }
            if (e == "e")
            {
                TempData["AlertMessage"] = " What is the best and worst purchases you’ve ever made?";
            }
            if (f == "f")
            {
                TempData["AlertMessage"] = "If you had to change your name, what would your new name be ?";
            }
            if (g == "g")
            {
                TempData["AlertMessage"] = " What is the best and worst purchases you’ve ever made?";
            }
            if (h == "h")
            {
                TempData["AlertMessage"] = " What is the best and worst purchases you’ve ever made?";
            }
            if (h == "h")
            {
                TempData["AlertMessage"] = " What is the best and worst purchases you’ve ever made?";
            }
            if (h == "h")
            {
                TempData["AlertMessage"] = " What is the best and worst purchases you’ve ever made?";
            }
            if (h == "h")
            {
                TempData["AlertMessage"] = " What is the best and worst purchases you’ve ever made?";
            }
            if (h == "h")
            {
                TempData["AlertMessage"] = " What is the best and worst purchases you’ve ever made?";
            }
            if (h == "h")
            {
                TempData["AlertMessage"] = " What is the best and worst purchases you’ve ever made?";
            }

            return View();
        }
    }
}