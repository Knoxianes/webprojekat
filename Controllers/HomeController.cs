using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProjekat.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Proizvod(string naziv)
        {
            return View();
        }
        public ActionResult Izmena(string naziv)
        {
            return View();
        }
    }
}