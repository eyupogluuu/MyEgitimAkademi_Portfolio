using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        myPortfolioDBEntities db = new myPortfolioDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult partialHead()
        {
            return PartialView();
        }

        public PartialViewResult partialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult partialQuickContact()
        {
            return PartialView();
        }
        public PartialViewResult partialFeature()
        {
            return PartialView();
        }
        public PartialViewResult partialService()
        {
            var values = db.Service.ToList();
            return PartialView(values);
        }
        public PartialViewResult partialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }
        public PartialViewResult partialAward()
        {
            var values = db.Awards.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialTestimonial()
        {
            var values = db.Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialExperience()
        {
            var values = db.Experience.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialcontact(Contact c)
        {
            db.Contact.Add(c);
            db.SaveChanges();
            ViewBag.descreption = db.Adress.Select(x => x.descreption).FirstOrDefault();
            ViewBag.phone = db.Adress.Select(x => x.phone).FirstOrDefault();
            ViewBag.adressDetail = db.Adress.Select(x => x.adressDetail).FirstOrDefault();
            ViewBag.email = db.Adress.Select(x => x.email).FirstOrDefault();

            return PartialView();
        }
        public PartialViewResult partialPopup()
        {
            return PartialView();
        }




    }
}