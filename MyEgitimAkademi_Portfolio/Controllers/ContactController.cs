using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        myPortfolioDBEntities db = new myPortfolioDBEntities();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.descreption = db.Adress.Select(x => x.descreption).FirstOrDefault();
            ViewBag.phone = db.Adress.Select(x => x.phone).FirstOrDefault();
            ViewBag.adressDetail = db.Adress.Select(x => x.adressDetail).FirstOrDefault();
            ViewBag.email = db.Adress.Select(x => x.email).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact c)
        {
            db.Contact.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index","Default");
        }

        public PartialViewResult partialScript()
        {
            return PartialView();
        }
    }
}