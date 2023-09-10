using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{

    public class LoginController : Controller
    {
        myPortfolioDBEntities db = new myPortfolioDBEntities();
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index( Admin a)
        {
            var values = db.Admin.FirstOrDefault(x => x.username == a.username && x.password == a.password);
            if (values !=null)
            {
                FormsAuthentication.SetAuthCookie(values.username, false);//kullanıcı adını hatırlama dedik true yapsaydık hatırlardı burada şifre ve kullanıcı adını hatırlatabilirliz
                Session["username"] = values.username.ToString();
                return RedirectToAction("Index", "Service");
            }
            return View();
        }
    }
}