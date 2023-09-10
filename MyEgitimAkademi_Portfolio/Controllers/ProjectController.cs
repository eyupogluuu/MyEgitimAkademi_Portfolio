using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        myPortfolioDBEntities db = new myPortfolioDBEntities();
        public ActionResult Index()
        {
            var values = db.Projects.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult projectAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult projectAdd(Projects p )
        {
            db.Projects.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","Project");
        }
    }
}