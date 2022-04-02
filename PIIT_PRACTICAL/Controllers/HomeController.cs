using PIIT_PRACTICAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIIT_PRACTICAL.Controllers
{
    public class HomeController : Controller
    {
        public MyDbContext db = new MyDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Market()
        {
            var coinList = db.Coins.ToList();
            return View(coinList);
        }
    }
}