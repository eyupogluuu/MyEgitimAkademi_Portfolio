using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        myPortfolioDBEntities db = new myPortfolioDBEntities();
        public ActionResult Index()
        {
            var values = db.Experience.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(Experience e)
        {
            db.Experience.Add(e);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            var values=db.Experience.Find(id);
            db.Experience.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var values = db.Experience.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateExperience(Experience e)
        {
            var values = db.Experience.Find(e.experienceID);
            values.experiencetittle = e.experiencetittle;
            values.experienceperiod = e.experienceperiod;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}