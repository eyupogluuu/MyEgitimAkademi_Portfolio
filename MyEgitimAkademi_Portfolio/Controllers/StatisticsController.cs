using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class StatisticsController : Controller
    {
        myPortfolioDBEntities db = new myPortfolioDBEntities();
        public ActionResult Index()
        {
            ViewBag.totalProjectCount = db.Projects.Count();
            ViewBag.totalTestimonialCount = db.Testimonial.Count();
            ViewBag.sumworkday = db.Projects.Sum(x => x.completeDay);
            ViewBag.avgWorkDay = db.Projects.Average(x => x.completeDay);
            ViewBag.avgPrice = db.Projects.Average(x => x.price);
            var value = db.Projects.Max(x => x.price);
            ViewBag.maxPriceProject = db.Projects.Where(x => x.price == value).Select(y => y.tittle).FirstOrDefault();
            var values2 = db.Category.Where(x => x.categoryName == "AspNet Core Web Geliştirme").Select(y => y.categoryID).FirstOrDefault();
            ViewBag.categorycountbyName = db.Projects.Where(x => x.projectCategory == values2).Count();
            return View();
        }
    }
}