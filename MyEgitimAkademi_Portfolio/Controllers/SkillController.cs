using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class SkillController : Controller
    {
        myPortfolioDBEntities db = new myPortfolioDBEntities();
        public ActionResult Index()
        {
            var values = db.Skill.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(Skill s)
        {
            db.Skill.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
         public ActionResult DeleteSkill(int id)
        {
            var values = db.Skill.Find(id);
            db.Skill.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var values = db.Skill.Find(id);
            return View(values);
        }
         [HttpPost]
         public ActionResult UpdateSkill(Skill s)
        {
            var value = db.Skill.Find(s.skillID);
            value.skillName = s.skillName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}