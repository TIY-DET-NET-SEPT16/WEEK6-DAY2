using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialClasses.Models;

namespace PartialClasses.Controllers
{
    public class HomeController : Controller
    {
        private MovieRentalEntities db = new MovieRentalEntities();

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

            var overDue = from r in db.RentalRecords
                          join c in db.Customers on r.CustomerID equals c.CustomerID
                          where r.DueDate < DateTime.Today && r.ReturnDate == null
                          select new ContactViewModel
                          {
                              CustomerToContact = c.CustomerName,
                              PhoneNumber = c.CustomerPhoneNum,
                              MovieOverdue = r.Movy
                          };

            //var v = new[] { new { Amount = 83, Message = "Hello World" },
            //    new { Amount = 54, Message = "Goodbye Cruel World" } };

            return View(overDue);
        }
    }
}