using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ServiceController : Controller
    {
        myPortfolioDBEntities db = new myPortfolioDBEntities();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Service.ToList();
            return View(values);//vievin içinde values değerlerini de getir
        }

        [HttpGet]
        public ActionResult ServiceAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ServiceAdd(Service s)
        {
            db.Service.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}