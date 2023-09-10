using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class RegisterController : Controller
        
    {
        myPortfolioDBEntities db = new myPortfolioDBEntities();

       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin a)
        {
            db.Admin.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}