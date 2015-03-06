using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class AboutMeController : Controller
    {
        // GET: AboutMe
        public ActionResult Index()
        {
            ViewBag.Message = "Your About Me description page.";
            return View();
        }

        // GET: Cool Pics
        public ActionResult CoolPics()
        {
            ViewBag.Message = "Your Cool Pics description page.";
            return View();
        }

    }
}