using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class TestimonialController : Controller
    {
        myPortfolioDBEntities db = new myPortfolioDBEntities();
        public ActionResult Index()
        {
            var values = db.Testimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTestimonial(Testimonial t)
        {
            db.Testimonial.Add(t);// t burda testimonial tablosuna dışardan ekleyeceğimiz parametleri tutacak
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.Testimonial.Find(id);
            db.Testimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id) // burada parametreye id ismini vermemizdeki zorunluluk roodconfig de zorunlu olarak id istemesi
        {
            var value = db.Testimonial.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial t) 
        {
            var value = db.Testimonial.Find(t.testimonialID); //gönderilen idden güncellemek istediğim
            value.nameSurname = t.nameSurname;
            value.tittle = t.tittle;
            value.imageUrl = t.imageUrl;
            value.comment = t.comment;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}