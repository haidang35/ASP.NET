using PIIT_PRACTICAL.Data;
using PIIT_PRACTICAL.Models;
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
            return RedirectToAction("Market");
        }

        public ActionResult About()
        {
            return RedirectToAction("Market");
        }

        public ActionResult Contact()
        {
            return RedirectToAction("Market");
        }

        public ActionResult Market(string marketName, string coinName)
        {
            var coinList = new List<Coin>();
            if (! string.IsNullOrEmpty(marketName))
            {
                var market = db.Markets.Where(m => m.Name == marketName).FirstOrDefault();
                if(market != null)
                {
                    coinList = db.Coins.Where(c => c.MarketId == market.Id).ToList();
                }
            }else
            {
                coinList = db.Coins.ToList();
            }

            if(! string.IsNullOrEmpty(coinName))
            {
                coinList = coinList.Where(c => c.Name.Contains(coinName)).ToList();
            }
            var markets = new SelectList(db.Markets.ToList(), "Name", "Name", marketName);
            ViewBag.Markets = markets;
            ViewBag.coinName = coinName;
            return View(coinList);
        }
    }
}