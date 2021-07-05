using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var modal = new GreetingViewModal();
            modal.Name = name ?? "no name";
            modal.Message = ConfigurationManager.AppSettings["message"];
            return View(modal);
        }
    }
}