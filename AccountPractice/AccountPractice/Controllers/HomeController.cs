using AccountPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountPractice.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult Money(MoneyViewModel vm)
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }

        [ChildActionOnly]
        public ActionResult ShowHistory()
        {
            var history = new List<MoneyViewModel>
            {
                new MoneyViewModel {type=AccountingType.收入,price=40000 , date = new DateTime(2016,4,10), memo="薪水" },
                new MoneyViewModel {type=AccountingType.支出, price=100, date = new DateTime(2016,4,11), memo="7-11午餐" },
            };

            return View(history);
        }
    }
}