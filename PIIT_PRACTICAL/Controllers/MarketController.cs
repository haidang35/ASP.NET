using PIIT_PRACTICAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIIT_PRACTICAL.Controllers
{
    public class MarketController : Controller
    {
        public MyDbContext db = new MyDbContext();
        // GET: Market
        public ActionResult Index(string name, string martketName)
        {
            var market = db.Markets.ToList();
            ViewBag.Market = market;
            var coinList = db.Coins.ToList();
            return View(coinList);
        }
    }
}