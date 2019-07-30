using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTAsk.Models;

namespace TestTAsk.Controllers
{
    public class PatController : Controller
    {
        public ActionResult Index(string phone)
        {
            DataContext dc = new DataContext();
            dc.apps.Add(new App
            {
                name = phone,
                status = "В очереди"
            });
            dc.SaveChanges();
            return View();
        }
    }
}