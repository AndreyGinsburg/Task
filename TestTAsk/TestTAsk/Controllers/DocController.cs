using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTAsk.Models;

namespace TestTAsk.Controllers
{
    public class DocController : Controller
    {
        DataContext dc = new DataContext();
        public ActionResult Index(string password)
        {
            if (password == "doctor")
            {
                return View(dc.apps.ToList());
            }
            else return View("Error");
        }

        public ActionResult ChangeStatus(int id)
        {
            dc.apps.Find(id).status = "Активен";
            return View("Index");
        }

        public ActionResult Delete(int id)
        {
            dc.apps.Remove(dc.apps.Find(id));
            return View("Index");
        }
    }
}