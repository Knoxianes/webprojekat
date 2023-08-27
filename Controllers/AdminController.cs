using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProjekat.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Korisnici()
        {
            return View();
        }
        public ActionResult Proizvodi()
        {
            return View();
        }
        public ActionResult Porudzbine()
        {
            return View();
        }
        public ActionResult Recenzije()
        {
            return View();
        }
        public ActionResult Dodaj()
        {
            return View();
        }
        public ActionResult IzmenaKorisnika()
        {
            return View();
        }
        public ActionResult IzmenaProizvoda()
        {
            return View();
        }
    }
}